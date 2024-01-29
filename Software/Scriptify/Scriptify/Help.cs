﻿using Patagames.Pdf.Enums;
using Patagames.Pdf.Net;
using Patagames.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Scriptify {
    public partial class Help : Form {
        public Help() {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e) {
            PdfLoader();
        }
        private void PdfLoader() {
            try {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string pdfFilePath = Path.Combine(baseDirectory, "sample.pdf");
                

                if (File.Exists(pdfFilePath)) {
                    using (var doc = PdfDocument.Load(pdfFilePath)) {
                        var page = doc.Pages[0];

                        int width = (int)page.Width;
                        int height = (int)page.Height;

                        using (var bitmap = new PdfBitmap(width, height, true)) {
                            bitmap.FillRect(0, 0, width, height, FS_COLOR.White);
                            page.Render(bitmap, 0, 0, width, height, PageRotate.Normal, RenderFlags.FPDF_NONE);

                            bitmap.GetImage().Save("sample.png", ImageFormat.Png);
                            pc_help.ImageLocation = "sample.png";
                        }
                    }
                } else {
                    MessageBox.Show(baseDirectory, "Pdf Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            } catch (Exception e) {
                MessageBox.Show("Error loading PDF: " + e.Message, "Pdf Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }


    }
}
