using System;
using System.Drawing;
using System.Windows.Forms;
using SlotMachine_App.Logic;

namespace SlotMachine_App.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.timerCiclu = new System.Windows.Forms.Timer(this.components);
            this.btnTrage = new System.Windows.Forms.Button();
            this.numericUpDownCicluri = new System.Windows.Forms.NumericUpDown();
            this.labelRezultat = new System.Windows.Forms.Label();
            this.pictureBoxSlot1 = new System.Windows.Forms.PictureBox();
            this.labelCicluri = new System.Windows.Forms.Label();
            this.pictureBoxSlot2 = new System.Windows.Forms.PictureBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.pictureBoxSlot3 = new System.Windows.Forms.PictureBox();
            this.panelSloturi = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCicluri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlot3)).BeginInit();
            this.panelSloturi.SuspendLayout();
            this.SuspendLayout();
            //
            // labelTitlu
            //
            this.labelTitlu.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelTitlu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.labelTitlu.Location = new System.Drawing.Point(12, 9);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(679, 76);
            this.labelTitlu.TabIndex = 6;
            this.labelTitlu.Text = "SLOT MACHINE";
            this.labelTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // timerCiclu
            //
            this.timerCiclu.Interval = 500;
            this.timerCiclu.Tick += new System.EventHandler(this.timerCiclu_Tick);
            //
            // btnTrage
            //
            this.btnTrage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTrage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTrage.ForeColor = System.Drawing.Color.White;
            this.btnTrage.Location = new System.Drawing.Point(481, 453);
            this.btnTrage.Name = "btnTrage";
            this.btnTrage.Size = new System.Drawing.Size(120, 76);
            this.btnTrage.TabIndex = 4;
            this.btnTrage.Text = "Trage!";
            this.btnTrage.UseVisualStyleBackColor = false;
            this.btnTrage.Click += new System.EventHandler(this.btnTrage_Click);
            //
            // numericUpDownCicluri
            //
            this.numericUpDownCicluri.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numericUpDownCicluri.Location = new System.Drawing.Point(330, 453);
            this.numericUpDownCicluri.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownCicluri.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCicluri.Name = "numericUpDownCicluri";
            this.numericUpDownCicluri.Size = new System.Drawing.Size(103, 29);
            this.numericUpDownCicluri.TabIndex = 3;
            this.numericUpDownCicluri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownCicluri.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            //
            // labelRezultat
            //
            this.labelRezultat.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelRezultat.Location = new System.Drawing.Point(30, 392);
            this.labelRezultat.Name = "labelRezultat";
            this.labelRezultat.Size = new System.Drawing.Size(635, 58);
            this.labelRezultat.TabIndex = 5;
            this.labelRezultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pictureBoxSlot1
            //
            this.pictureBoxSlot1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSlot1.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxSlot1.Name = "pictureBoxSlot1";
            this.pictureBoxSlot1.Size = new System.Drawing.Size(205, 292);
            this.pictureBoxSlot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSlot1.TabIndex = 0;
            this.pictureBoxSlot1.TabStop = false;
            //
            // labelCicluri
            //
            this.labelCicluri.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelCicluri.Location = new System.Drawing.Point(85, 455);
            this.labelCicluri.Name = "labelCicluri";
            this.labelCicluri.Size = new System.Drawing.Size(206, 22);
            this.labelCicluri.TabIndex = 7;
            this.labelCicluri.Text = "Număr de cicluri (învârtiri):";
            this.labelCicluri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pictureBoxSlot2
            //
            this.pictureBoxSlot2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSlot2.Location = new System.Drawing.Point(214, 3);
            this.pictureBoxSlot2.Name = "pictureBoxSlot2";
            this.pictureBoxSlot2.Size = new System.Drawing.Size(205, 292);
            this.pictureBoxSlot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSlot2.TabIndex = 1;
            this.pictureBoxSlot2.TabStop = false;
            //
            // labelInfo
            //
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.labelInfo.ForeColor = System.Drawing.Color.Gray;
            this.labelInfo.Location = new System.Drawing.Point(52, 496);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(348, 51);
            this.labelInfo.TabIndex = 8;
            this.labelInfo.Text = "Câștigi când toate cele 3 simboluri sunt identice!\r\nFiecare ciclu durează 0.5 sec" + "unde.";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pictureBoxSlot3
            //
            this.pictureBoxSlot3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSlot3.Location = new System.Drawing.Point(425, 3);
            this.pictureBoxSlot3.Name = "pictureBoxSlot3";
            this.pictureBoxSlot3.Size = new System.Drawing.Size(205, 292);
            this.pictureBoxSlot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSlot3.TabIndex = 2;
            this.pictureBoxSlot3.TabStop = false;
            //
            // panelSloturi
            //
            this.panelSloturi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelSloturi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSloturi.Controls.Add(this.pictureBoxSlot3);
            this.panelSloturi.Controls.Add(this.pictureBoxSlot2);
            this.panelSloturi.Controls.Add(this.pictureBoxSlot1);
            this.panelSloturi.Location = new System.Drawing.Point(30, 88);
            this.panelSloturi.Name = "panelSloturi";
            this.panelSloturi.Size = new System.Drawing.Size(635, 300);
            this.panelSloturi.TabIndex = 10;
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 550);
            this.Controls.Add(this.panelSloturi);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelCicluri);
            this.Controls.Add(this.labelTitlu);
            this.Controls.Add(this.labelRezultat);
            this.Controls.Add(this.btnTrage);
            this.Controls.Add(this.numericUpDownCicluri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Machine - EGC Project";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCicluri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlot3)).EndInit();
            this.panelSloturi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label labelTitlu;
        private System.Windows.Forms.Timer timerCiclu;
        private Button btnTrage;
        private NumericUpDown numericUpDownCicluri;
        private Label labelRezultat;
        private PictureBox pictureBoxSlot1;
        private Label labelCicluri;
        private PictureBox pictureBoxSlot2;
        private Label labelInfo;
        private PictureBox pictureBoxSlot3;
        private Panel panelSloturi;
    }
}
