﻿namespace PostHttp
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboFormat = new System.Windows.Forms.ComboBox();
            this.textURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboPasteKeys = new System.Windows.Forms.ComboBox();
            this.checkPasteModShift = new System.Windows.Forms.CheckBox();
            this.checkPasteModAlt = new System.Windows.Forms.CheckBox();
            this.checkPasteModCtrl = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboDragKeys = new System.Windows.Forms.ComboBox();
            this.checkDragModShift = new System.Windows.Forms.CheckBox();
            this.checkDragModAlt = new System.Windows.Forms.CheckBox();
            this.checkDragModCtrl = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Format:";
            // 
            // comboFormat
            // 
            this.comboFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFormat.FormattingEnabled = true;
            this.comboFormat.Items.AddRange(new object[] {
            "PNG",
            "JPG",
            "GIF"});
            this.comboFormat.Location = new System.Drawing.Point(92, 12);
            this.comboFormat.Name = "comboFormat";
            this.comboFormat.Size = new System.Drawing.Size(142, 21);
            this.comboFormat.TabIndex = 0;
            // 
            // textURL
            // 
            this.textURL.Location = new System.Drawing.Point(92, 39);
            this.textURL.Name = "textURL";
            this.textURL.Size = new System.Drawing.Size(219, 20);
            this.textURL.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Endpoint URL:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(92, 65);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(142, 20);
            this.textName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Endpoint name:";
            // 
            // comboPasteKeys
            // 
            this.comboPasteKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPasteKeys.FormattingEnabled = true;
            this.comboPasteKeys.Location = new System.Drawing.Point(92, 164);
            this.comboPasteKeys.Name = "comboPasteKeys";
            this.comboPasteKeys.Size = new System.Drawing.Size(136, 21);
            this.comboPasteKeys.TabIndex = 48;
            // 
            // checkPasteModShift
            // 
            this.checkPasteModShift.AutoSize = true;
            this.checkPasteModShift.Location = new System.Drawing.Point(183, 141);
            this.checkPasteModShift.Name = "checkPasteModShift";
            this.checkPasteModShift.Size = new System.Drawing.Size(47, 17);
            this.checkPasteModShift.TabIndex = 47;
            this.checkPasteModShift.Text = "Shift";
            this.checkPasteModShift.UseVisualStyleBackColor = true;
            // 
            // checkPasteModAlt
            // 
            this.checkPasteModAlt.AutoSize = true;
            this.checkPasteModAlt.Location = new System.Drawing.Point(139, 141);
            this.checkPasteModAlt.Name = "checkPasteModAlt";
            this.checkPasteModAlt.Size = new System.Drawing.Size(38, 17);
            this.checkPasteModAlt.TabIndex = 46;
            this.checkPasteModAlt.Text = "Alt";
            this.checkPasteModAlt.UseVisualStyleBackColor = true;
            // 
            // checkPasteModCtrl
            // 
            this.checkPasteModCtrl.AutoSize = true;
            this.checkPasteModCtrl.Location = new System.Drawing.Point(92, 141);
            this.checkPasteModCtrl.Name = "checkPasteModCtrl";
            this.checkPasteModCtrl.Size = new System.Drawing.Size(41, 17);
            this.checkPasteModCtrl.TabIndex = 45;
            this.checkPasteModCtrl.Text = "Ctrl";
            this.checkPasteModCtrl.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Paste shortcut:";
            // 
            // comboDragKeys
            // 
            this.comboDragKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDragKeys.FormattingEnabled = true;
            this.comboDragKeys.Location = new System.Drawing.Point(92, 114);
            this.comboDragKeys.Name = "comboDragKeys";
            this.comboDragKeys.Size = new System.Drawing.Size(136, 21);
            this.comboDragKeys.TabIndex = 44;
            // 
            // checkDragModShift
            // 
            this.checkDragModShift.AutoSize = true;
            this.checkDragModShift.Location = new System.Drawing.Point(183, 91);
            this.checkDragModShift.Name = "checkDragModShift";
            this.checkDragModShift.Size = new System.Drawing.Size(47, 17);
            this.checkDragModShift.TabIndex = 43;
            this.checkDragModShift.Text = "Shift";
            this.checkDragModShift.UseVisualStyleBackColor = true;
            // 
            // checkDragModAlt
            // 
            this.checkDragModAlt.AutoSize = true;
            this.checkDragModAlt.Location = new System.Drawing.Point(139, 91);
            this.checkDragModAlt.Name = "checkDragModAlt";
            this.checkDragModAlt.Size = new System.Drawing.Size(38, 17);
            this.checkDragModAlt.TabIndex = 42;
            this.checkDragModAlt.Text = "Alt";
            this.checkDragModAlt.UseVisualStyleBackColor = true;
            // 
            // checkDragModCtrl
            // 
            this.checkDragModCtrl.AutoSize = true;
            this.checkDragModCtrl.Location = new System.Drawing.Point(92, 91);
            this.checkDragModCtrl.Name = "checkDragModCtrl";
            this.checkDragModCtrl.Size = new System.Drawing.Size(41, 17);
            this.checkDragModCtrl.TabIndex = 41;
            this.checkDragModCtrl.Text = "Ctrl";
            this.checkDragModCtrl.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Drag shortcut:";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 345);
            this.Controls.Add(this.comboPasteKeys);
            this.Controls.Add(this.checkPasteModShift);
            this.Controls.Add(this.checkPasteModAlt);
            this.Controls.Add(this.checkPasteModCtrl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboDragKeys);
            this.Controls.Add(this.checkDragModShift);
            this.Controls.Add(this.checkDragModAlt);
            this.Controls.Add(this.checkDragModCtrl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textURL);
            this.Controls.Add(this.comboFormat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostHttp Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboFormat;
        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboPasteKeys;
        private System.Windows.Forms.CheckBox checkPasteModShift;
        private System.Windows.Forms.CheckBox checkPasteModAlt;
        private System.Windows.Forms.CheckBox checkPasteModCtrl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboDragKeys;
        private System.Windows.Forms.CheckBox checkDragModShift;
        private System.Windows.Forms.CheckBox checkDragModAlt;
        private System.Windows.Forms.CheckBox checkDragModCtrl;
        private System.Windows.Forms.Label label8;
    }
}