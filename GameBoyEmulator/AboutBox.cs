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
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace GameBoyEmulator {
  partial class AboutBox : Form {
    public AboutBox() {
      InitializeComponent();      
      this.labelProductName.Text = AssemblyProduct;
      this.labelVersion.Text = String.Format("Beta Version {0}", AssemblyVersion);
      this.labelCopyright.Text = AssemblyCopyright;
      this.meatfighterLinkLabel.Links.Add(0, 22, "http://meatfighter.com");
    }

    #region Assembly Attribute Accessors

    public string AssemblyTitle {
      get {
        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
        if (attributes.Length > 0) {
          AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
          if (titleAttribute.Title != "") {
            return titleAttribute.Title;
          }
        }
        return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
      }
    }

    public string AssemblyVersion {
      get {
        return Assembly.GetExecutingAssembly().GetName().Version.ToString();
      }
    }

    public string AssemblyDescription {
      get {
        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
        if (attributes.Length == 0) {
          return "";
        }
        return ((AssemblyDescriptionAttribute)attributes[0]).Description;
      }
    }

    public string AssemblyProduct {
      get {
        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
        if (attributes.Length == 0) {
          return "";
        }
        return ((AssemblyProductAttribute)attributes[0]).Product;
      }
    }

    public string AssemblyCopyright {
      get {
        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
        if (attributes.Length == 0) {
          return "";
        }
        return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
      }
    }

    public string AssemblyCompany {
      get {
        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
        if (attributes.Length == 0) {
          return "";
        }
        return ((AssemblyCompanyAttribute)attributes[0]).Company;
      }
    }
    #endregion

    private void meatfighterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
    }
  }
}
