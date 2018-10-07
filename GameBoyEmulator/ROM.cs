/*
 * Game Boy Emulator
 * Copyright (C) 2008 Michael Birken
 * 
 * This file is part of Game Boy Emulator.
 *
 * Game Boy Emulator is free software; you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published 
 * by the Free Software Foundation; either version 3 of the License, or
 * (at your option) any later version.
 *
 * Game Boy Emulator is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GameBoyEmulator {

  enum RomType {
    ROM = 0x00,
    ROM_MBC1 = 0x01,
    ROM_MBC1_RAM = 0x02,
    ROM_MBC1_RAM_BATT = 0x03,
    ROM_MBC2 = 0x05,
    ROM_MBC2_BATTERY = 0x06,
    ROM_RAM = 0x08,
    ROM_RAM_BATTERY = 0x09,
    ROM_MMM01 = 0x0B,
    ROM_MMM01_SRAM = 0x0C,
    ROM_MMM01_SRAM_BATT = 0x0D,
    ROM_MBC3_TIMER_BATT = 0x0F,
    ROM_MBC3_TIMER_RAM_BATT = 0x10,
    ROM_MBC3 = 0x11,
    ROM_MBC3_RAM = 0x12,
    ROM_MBC3_RAM_BATT = 0x13,
    ROM_MBC5 = 0x19,
    ROM_MBC5_RAM = 0x1A,
    ROM_MBC5_RAM_BATT = 0x1B,
    ROM_MBC5_RUMBLE = 0x1C,
    ROM_MBC5_RUMBLE_SRAM = 0x1D,
    ROM_MBC5_RUMBLE_SRAM_BATT = 0x1E,
    PocketCamera = 0x1F,
    BandaiTAMA5 = 0xFD,
    HudsonHuC3 = 0xFE,
    HudsonHuC1 = 0xFF,
  }

  class ROMLoader {

    public Game Load(string fileName) {

      FileInfo fileInfo = new FileInfo(fileName);
      byte[] fileData = new byte[fileInfo.Length];
      FileStream fileStream = fileInfo.OpenRead();
      fileStream.Read(fileData, 0, fileData.Length);
      fileStream.Close();

      return new Game(fileData);      
    }
  }

  class Game {
    public string title;
    public bool gameBoyColorGame;
    public int licenseCode;
    public bool gameBoy;
    public RomType romType;
    public int romSize;
    public int romBanks;
    public int ramSize;
    public int ramBanks;
    public bool japanese;
    public int oldLicenseCode;
    public int maskRomVersion;
    public int checksum;
    public int actualChecksum;
    public int headerChecksum;
    public int actualHeaderChecksum;
    public bool noVerticalBlankInterruptHandler;
    public bool noLCDCStatusInterruptHandler;
    public bool noTimerOverflowInterruptHandler;
    public bool noSerialTransferCompletionInterruptHandler;
    public bool noHighToLowOfP10ToP13InterruptHandler;
    public ICartridge cartridge;

    public Game(byte[] fileData) {
      title = ExtractGameTitle(fileData);
      gameBoyColorGame = fileData[0x0143] == 0x80;
      licenseCode = (((int)fileData[0x0144]) << 4) | fileData[0x0145];
      gameBoy = fileData[0x0146] == 0x00;
      romType = (RomType)fileData[0x0147];

      switch (fileData[0x0148]) {
        case 0x00:
          romSize = 32 * 1024;
          romBanks = 2;
          break;
        case 0x01:
          romSize = 64 * 1024;
          romBanks = 4;
          break;
        case 0x02:
          romSize = 128 * 1024;
          romBanks = 8;
          break;
        case 0x03:
          romSize = 256 * 1024;
          romBanks = 16;
          break;
        case 0x04:
          romSize = 512 * 1024;
          romBanks = 32;
          break;
        case 0x05:
          romSize = 1024 * 1024;
          romBanks = 64;
          break;
        case 0x06:
          romSize = 2 * 1024 * 1024;
          romBanks = 128;
          break;
        case 0x52:
          romSize = 1179648;
          romBanks = 72;
          break;
        case 0x53:
          romSize = 1310720;
          romBanks = 80;
          break;
        case 0x54:
          romSize = 1572864;
          romBanks = 96;
          break;
      }

      switch (fileData[0x0149]) {
        case 0x00:
          ramSize = 0;
          ramBanks = 0;
          break;
        case 0x01:
          ramSize = 2 * 1024;
          ramBanks = 1;
          break;
        case 0x02:
          ramSize = 8 * 1024;
          ramBanks = 1;
          break;
        case 0x03:
          ramSize = 32 * 1024;
          ramBanks = 4;
          break;
        case 0x04:
          ramSize = 128 * 1024;
          ramBanks = 16;
          break;
      }

      japanese = fileData[0x014A] == 0x00;
      oldLicenseCode = fileData[0x014B];
      maskRomVersion = fileData[0x014C];

      headerChecksum = fileData[0x014D];
      for(int i = 0x0134; i <= 0x014C; i++) {
        actualHeaderChecksum = actualHeaderChecksum - fileData[i] - 1;
      }
      actualHeaderChecksum &= 0xFF;      

      checksum = (((int)fileData[0x014E]) << 8) | fileData[0x014F];
      for (int i = 0; i < fileData.Length; i++) {
        if (i != 0x014E && i != 0x014F) {
          actualChecksum += fileData[i];
        }
      }
      actualChecksum &= 0xFFFF;

      noVerticalBlankInterruptHandler = fileData[0x0040] == 0xD9;
      noLCDCStatusInterruptHandler = fileData[0x0048] == 0xD9;
      noTimerOverflowInterruptHandler = fileData[0x0050] == 0xD9;
      noSerialTransferCompletionInterruptHandler = fileData[0x0058] == 0xD9;
      noHighToLowOfP10ToP13InterruptHandler = fileData[0x0060] == 0xD9;

      switch (romType) {
        case RomType.ROM:
          cartridge = new ROM(fileData);
          break;
        case RomType.ROM_MBC1:
        case RomType.ROM_MBC1_RAM:
        case RomType.ROM_MBC1_RAM_BATT:
          cartridge = new MBC1(fileData, romType, romSize, romBanks);
          break;
        case RomType.ROM_MBC2:
        case RomType.ROM_MBC2_BATTERY:
          cartridge = new MBC2(fileData, romType, romSize, romBanks);
          break;
        default:
          throw new Exception(string.Format("Cannot emulate cartridge type {0}.", romType)); 
      }
    }

    private string ExtractGameTitle(byte[] fileData) {
      StringBuilder sb = new StringBuilder();
      for (int i = 0x0134; i <= 0x0142; i++) {
        if (fileData[i] == 0x00) {
          break;
        }
        sb.Append((char)fileData[i]);
      }
      return sb.ToString();
    }

    public override string ToString() {
      return "title = " + title + "\n"
          + "game boy color game = " + gameBoyColorGame + "\n"
          + "license code = " + licenseCode + "\n"
          + "game boy = " + gameBoy + "\n"
          + "rom type = " + romType + "\n"
          + "rom size = " + romSize + "\n"
          + "rom banks = " + romBanks + "\n"
          + "ram size = " + ramSize + "\n"
          + "ram banks = " + ramBanks + "\n"
          + "japanese = " + japanese + "\n"
          + "old license code = " + oldLicenseCode + "\n"
          + "mask rom version = " + maskRomVersion + "\n"
          + "header checksum = " + headerChecksum + "\n"
          + "actual header checksum = " + actualHeaderChecksum + "\n"
          + "checksum = " + checksum + "\n"
          + "actual checksum = " + actualChecksum + "\n"
          + "no vertical blank interrupt handler = " + noVerticalBlankInterruptHandler + "\n"
          + "no lcd status interrupt handler = " + noLCDCStatusInterruptHandler + "\n"
          + "no timer overflow interrupt handler = " + noTimerOverflowInterruptHandler + "\n"
          + "no serial transfer completion interrupt handler = " + noSerialTransferCompletionInterruptHandler + "\n"
          + "no high to lower of P10-P13 interrupt handler = " + noHighToLowOfP10ToP13InterruptHandler + "\n";
    }
  }

  class ROM : ICartridge {

    private byte[] fileData;

    public ROM(byte[] fileData) {
      this.fileData = fileData;
    }

    public int ReadByte(int address) {
      return fileData[0x7FFF & address];
    }

    public void WriteByte(int address, int value) {
    }
  }

  class MBC1 : ICartridge {

    private RomType romType;
    private bool ramBankingMode;
    private int selectedRomBank = 1;
    private int selectedRamBank;
    private byte[,] ram = new byte[4, 8 * 1024];
    private byte[,] rom;

    public MBC1(byte[] fileData, RomType romType, int romSize, int romBanks) {
      this.romType = romType;
      int bankSize = romSize / romBanks;
      rom = new byte[romBanks, bankSize];
      for (int i = 0, k = 0; i < romBanks; i++) {
        for (int j = 0; j < bankSize; j++, k++) {
          rom[i, j] = fileData[k];
        }
      }
    }

    public int ReadByte(int address) {
      if (address <= 0x3FFF) {
        return rom[0, address];
      } else if (address >= 0x4000 && address <= 0x7FFF) {
        return rom[selectedRomBank, address - 0x4000];
      } else if (address >= 0xA000 && address <= 0xBFFF) {
        return ram[selectedRamBank, address - 0xA000];
      }
      throw new Exception(string.Format("Invalid cartridge read: {0:X}", address));
    }

    public void WriteByte(int address, int value) {
      if (address >= 0xA000 && address <= 0xBFFF) {
        ram[selectedRamBank, address - 0xA000] = (byte)(0xFF & value);
      } else if (address >= 0x6000 && address <= 0x7FFF) {
        ramBankingMode = (value & 0x01) == 0x01;         
      } else if (address >= 0x2000 && address <= 0x3FFF) {        
        int selectedRomBankLow = 0x1F & value;
        if (selectedRomBankLow == 0x00) {
          selectedRomBankLow++;
        }
        selectedRomBank = (selectedRomBank & 0x60) | selectedRomBankLow;
      } else if (address >= 0x4000 && address <= 0x5FFF) {
        if (ramBankingMode) {
          selectedRamBank = 0x03 & value;
        } else {
          selectedRomBank = (selectedRomBank & 0x1F) | ((0x03 & value) << 5);
        }
      } 
    }
  }

  class MBC2 : ICartridge {

    private RomType romType;
    private int selectedRomBank = 1;
    private byte[] ram = new byte[512];
    private byte[,] rom;

    public MBC2(byte[] fileData, RomType romType, int romSize, int romBanks) {
      this.romType = romType;
      int bankSize = romSize / romBanks;
      rom = new byte[romBanks, bankSize];
      for (int i = 0, k = 0; i < romBanks; i++) {
        for (int j = 0; j < bankSize; j++, k++) {
          rom[i, j] = fileData[k];
        }
      }
    }

    public int ReadByte(int address) {
      if (address <= 0x3FFF) {
        return rom[0, address];
      } else if (address >= 0x4000 && address <= 0x7FFF) {
        return rom[selectedRomBank, address - 0x4000];
      } else if (address >= 0xA000 && address <= 0xA1FF) {
        return ram[address - 0xA000];
      }
      throw new Exception(string.Format("Invalid cartridge address: {0}", address));
    }

    public void WriteByte(int address, int value) {
      if (address >= 0xA000 && address <= 0xA1FF) {
        ram[address - 0xA000] = (byte)(0x0F & value);
      } else if (address >= 0x2000 && address <= 0x3FFF) {
        selectedRomBank = 0x0F & value;
      } 
    }
  }
}