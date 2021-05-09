﻿namespace workspacer
{
    partial class TextBlockMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MessageText = new System.Windows.Forms.TextBox();
            this.SubtitleText = new System.Windows.Forms.Label();
            this.ButtonLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // MessageText
            // 
            this.MessageText.BackColor = System.Drawing.SystemColors.Window;
            this.MessageText.Location = new System.Drawing.Point(18, 42);
            this.MessageText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MessageText.Multiline = true;
            this.MessageText.Name = "MessageText";
            this.MessageText.ReadOnly = true;
            this.MessageText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageText.Size = new System.Drawing.Size(882, 442);
            this.MessageText.TabIndex = 0;
            // 
            // SubtitleText
            // 
            this.SubtitleText.AutoSize = true;
            this.SubtitleText.Location = new System.Drawing.Point(14, 10);
            this.SubtitleText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubtitleText.Name = "SubtitleText";
            this.SubtitleText.Size = new System.Drawing.Size(0, 15);
            this.SubtitleText.TabIndex = 1;
            // 
            // ButtonLayout
            // 
            this.ButtonLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.ButtonLayout.Location = new System.Drawing.Point(18, 492);
            this.ButtonLayout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonLayout.Name = "ButtonLayout";
            this.ButtonLayout.Size = new System.Drawing.Size(883, 35);
            this.ButtonLayout.TabIndex = 2;
            // 
            // TextBlockMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 546);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonLayout);
            this.Controls.Add(this.SubtitleText);
            this.Controls.Add(this.MessageText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TextBlockMessage";
            this.ShowInTaskbar = false;
            this.Text = "workspacer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TextBlockMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.Label SubtitleText;
        private System.Windows.Forms.FlowLayoutPanel ButtonLayout;
    }
}