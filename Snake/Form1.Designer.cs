using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Keystroke.API;
namespace Snake
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.panel29 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.panel31 = new System.Windows.Forms.Panel();
            this.panel32 = new System.Windows.Forms.Panel();
            this.panel33 = new System.Windows.Forms.Panel();
            this.panel34 = new System.Windows.Forms.Panel();
            this.panel35 = new System.Windows.Forms.Panel();
            this.panel36 = new System.Windows.Forms.Panel();
            this.panel37 = new System.Windows.Forms.Panel();
            this.panel38 = new System.Windows.Forms.Panel();
            this.panel39 = new System.Windows.Forms.Panel();
            this.panel40 = new System.Windows.Forms.Panel();
            this.panel41 = new System.Windows.Forms.Panel();
            this.panel42 = new System.Windows.Forms.Panel();
            this.panel43 = new System.Windows.Forms.Panel();
            this.panel44 = new System.Windows.Forms.Panel();
            this.panel45 = new System.Windows.Forms.Panel();
            this.panel46 = new System.Windows.Forms.Panel();
            this.panel47 = new System.Windows.Forms.Panel();
            this.panel48 = new System.Windows.Forms.Panel();
            this.panel49 = new System.Windows.Forms.Panel();
            this.panel50 = new System.Windows.Forms.Panel();
            this.panel51 = new System.Windows.Forms.Panel();
            this.panel52 = new System.Windows.Forms.Panel();
            this.panel53 = new System.Windows.Forms.Panel();
            this.panel54 = new System.Windows.Forms.Panel();
            this.panel55 = new System.Windows.Forms.Panel();
            this.panel56 = new System.Windows.Forms.Panel();
            this.panel57 = new System.Windows.Forms.Panel();
            this.panel58 = new System.Windows.Forms.Panel();
            this.panel59 = new System.Windows.Forms.Panel();
            this.panel60 = new System.Windows.Forms.Panel();
            this.panel61 = new System.Windows.Forms.Panel();
            this.panel62 = new System.Windows.Forms.Panel();
            this.panel63 = new System.Windows.Forms.Panel();
            this.panel64 = new System.Windows.Forms.Panel();
            this.panel65 = new System.Windows.Forms.Panel();
            this.panel66 = new System.Windows.Forms.Panel();
            this.panel67 = new System.Windows.Forms.Panel();
            this.panel68 = new System.Windows.Forms.Panel();
            this.panel69 = new System.Windows.Forms.Panel();
            this.panel70 = new System.Windows.Forms.Panel();
            this.panel71 = new System.Windows.Forms.Panel();
            this.panel72 = new System.Windows.Forms.Panel();
            this.panel73 = new System.Windows.Forms.Panel();
            this.panel74 = new System.Windows.Forms.Panel();
            this.panel75 = new System.Windows.Forms.Panel();
            this.panel76 = new System.Windows.Forms.Panel();
            this.panel77 = new System.Windows.Forms.Panel();
            this.panel78 = new System.Windows.Forms.Panel();
            this.panel79 = new System.Windows.Forms.Panel();
            this.panel80 = new System.Windows.Forms.Panel();
            this.panel81 = new System.Windows.Forms.Panel();
            this.panel82 = new System.Windows.Forms.Panel();
            this.panel83 = new System.Windows.Forms.Panel();
            this.panel84 = new System.Windows.Forms.Panel();
            this.panel85 = new System.Windows.Forms.Panel();
            this.panel86 = new System.Windows.Forms.Panel();
            this.panel87 = new System.Windows.Forms.Panel();
            this.panel88 = new System.Windows.Forms.Panel();
            this.panel89 = new System.Windows.Forms.Panel();
            this.panel90 = new System.Windows.Forms.Panel();
            this.panel91 = new System.Windows.Forms.Panel();
            this.panel92 = new System.Windows.Forms.Panel();
            this.panel93 = new System.Windows.Forms.Panel();
            this.panel94 = new System.Windows.Forms.Panel();
            this.panel95 = new System.Windows.Forms.Panel();
            this.panel96 = new System.Windows.Forms.Panel();
            this.panel97 = new System.Windows.Forms.Panel();
            this.panel98 = new System.Windows.Forms.Panel();
            this.panel99 = new System.Windows.Forms.Panel();
            this.panel100 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel10, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel12, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel13, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel14, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel15, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel16, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel17, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel18, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel19, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel20, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel21, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel22, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel23, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel24, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel25, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel26, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel27, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel28, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel29, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel30, 9, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel31, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel32, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel33, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel34, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel35, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel36, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel37, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel38, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel39, 8, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel40, 9, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel41, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel42, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel43, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel44, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel45, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel46, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel47, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel48, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel49, 8, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel50, 9, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel51, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel52, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel53, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel54, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel55, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel56, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel57, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel58, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel59, 8, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel60, 9, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel61, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel62, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel63, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel64, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel65, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel66, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel67, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel68, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel69, 8, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel70, 9, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel71, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel72, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel73, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel74, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel75, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel76, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel77, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel78, 7, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel79, 8, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel80, 9, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel81, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.panel82, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.panel83, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.panel84, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.panel85, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.panel86, 5, 8);
            this.tableLayoutPanel1.Controls.Add(this.panel87, 6, 8);
            this.tableLayoutPanel1.Controls.Add(this.panel88, 7, 8);
            this.tableLayoutPanel1.Controls.Add(this.panel89, 8, 8);
            this.tableLayoutPanel1.Controls.Add(this.panel90, 9, 8);
            this.tableLayoutPanel1.Controls.Add(this.panel91, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.panel92, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.panel93, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.panel94, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.panel95, 4, 9);
            this.tableLayoutPanel1.Controls.Add(this.panel96, 5, 9);
            this.tableLayoutPanel1.Controls.Add(this.panel97, 6, 9);
            this.tableLayoutPanel1.Controls.Add(this.panel98, 7, 9);
            this.tableLayoutPanel1.Controls.Add(this.panel99, 8, 9);
            this.tableLayoutPanel1.Controls.Add(this.panel100, 9, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(608, 479);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(54, 41);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(63, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(54, 41);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(123, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(54, 41);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(183, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(54, 41);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(243, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(54, 41);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(303, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(54, 41);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(363, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(54, 41);
            this.panel7.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(423, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(54, 41);
            this.panel8.TabIndex = 7;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(483, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(54, 41);
            this.panel9.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(543, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(62, 41);
            this.panel10.TabIndex = 9;
            // 
            // panel11
            // 
            this.panel11.Location = new System.Drawing.Point(3, 50);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(54, 41);
            this.panel11.TabIndex = 10;
            // 
            // panel12
            // 
            this.panel12.Location = new System.Drawing.Point(63, 50);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(54, 41);
            this.panel12.TabIndex = 11;
            // 
            // panel13
            // 
            this.panel13.Location = new System.Drawing.Point(123, 50);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(54, 41);
            this.panel13.TabIndex = 12;
            // 
            // panel14
            // 
            this.panel14.Location = new System.Drawing.Point(183, 50);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(54, 41);
            this.panel14.TabIndex = 13;
            // 
            // panel15
            // 
            this.panel15.Location = new System.Drawing.Point(243, 50);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(54, 41);
            this.panel15.TabIndex = 14;
            // 
            // panel16
            // 
            this.panel16.Location = new System.Drawing.Point(303, 50);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(54, 41);
            this.panel16.TabIndex = 15;
            // 
            // panel17
            // 
            this.panel17.Location = new System.Drawing.Point(363, 50);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(54, 41);
            this.panel17.TabIndex = 16;
            // 
            // panel18
            // 
            this.panel18.Location = new System.Drawing.Point(423, 50);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(54, 41);
            this.panel18.TabIndex = 17;
            // 
            // panel19
            // 
            this.panel19.Location = new System.Drawing.Point(483, 50);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(54, 41);
            this.panel19.TabIndex = 18;
            // 
            // panel20
            // 
            this.panel20.Location = new System.Drawing.Point(543, 50);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(62, 41);
            this.panel20.TabIndex = 19;
            // 
            // panel21
            // 
            this.panel21.Location = new System.Drawing.Point(3, 97);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(54, 41);
            this.panel21.TabIndex = 20;
            // 
            // panel22
            // 
            this.panel22.Location = new System.Drawing.Point(63, 97);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(54, 41);
            this.panel22.TabIndex = 21;
            // 
            // panel23
            // 
            this.panel23.Location = new System.Drawing.Point(123, 97);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(54, 41);
            this.panel23.TabIndex = 22;
            // 
            // panel24
            // 
            this.panel24.Location = new System.Drawing.Point(183, 97);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(54, 41);
            this.panel24.TabIndex = 23;
            // 
            // panel25
            // 
            this.panel25.Location = new System.Drawing.Point(243, 97);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(54, 41);
            this.panel25.TabIndex = 24;
            // 
            // panel26
            // 
            this.panel26.Location = new System.Drawing.Point(303, 97);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(54, 41);
            this.panel26.TabIndex = 25;
            // 
            // panel27
            // 
            this.panel27.Location = new System.Drawing.Point(363, 97);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(54, 41);
            this.panel27.TabIndex = 26;
            // 
            // panel28
            // 
            this.panel28.Location = new System.Drawing.Point(423, 97);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(54, 41);
            this.panel28.TabIndex = 27;
            // 
            // panel29
            // 
            this.panel29.Location = new System.Drawing.Point(483, 97);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(54, 41);
            this.panel29.TabIndex = 28;
            // 
            // panel30
            // 
            this.panel30.Location = new System.Drawing.Point(543, 97);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(62, 41);
            this.panel30.TabIndex = 29;
            // 
            // panel31
            // 
            this.panel31.Location = new System.Drawing.Point(3, 144);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(54, 41);
            this.panel31.TabIndex = 30;
            // 
            // panel32
            // 
            this.panel32.Location = new System.Drawing.Point(63, 144);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(54, 41);
            this.panel32.TabIndex = 31;
            // 
            // panel33
            // 
            this.panel33.Location = new System.Drawing.Point(123, 144);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(54, 41);
            this.panel33.TabIndex = 32;
            // 
            // panel34
            // 
            this.panel34.Location = new System.Drawing.Point(183, 144);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(54, 41);
            this.panel34.TabIndex = 33;
            // 
            // panel35
            // 
            this.panel35.BackColor = System.Drawing.SystemColors.Control;
            this.panel35.Location = new System.Drawing.Point(243, 144);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(54, 41);
            this.panel35.TabIndex = 34;
            // 
            // panel36
            // 
            this.panel36.Location = new System.Drawing.Point(303, 144);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(54, 41);
            this.panel36.TabIndex = 35;
            // 
            // panel37
            // 
            this.panel37.Location = new System.Drawing.Point(363, 144);
            this.panel37.Name = "panel37";
            this.panel37.Size = new System.Drawing.Size(54, 41);
            this.panel37.TabIndex = 36;
            // 
            // panel38
            // 
            this.panel38.Location = new System.Drawing.Point(423, 144);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(54, 41);
            this.panel38.TabIndex = 37;
            // 
            // panel39
            // 
            this.panel39.Location = new System.Drawing.Point(483, 144);
            this.panel39.Name = "panel39";
            this.panel39.Size = new System.Drawing.Size(54, 41);
            this.panel39.TabIndex = 38;
            // 
            // panel40
            // 
            this.panel40.Location = new System.Drawing.Point(543, 144);
            this.panel40.Name = "panel40";
            this.panel40.Size = new System.Drawing.Size(62, 41);
            this.panel40.TabIndex = 39;
            // 
            // panel41
            // 
            this.panel41.Location = new System.Drawing.Point(3, 191);
            this.panel41.Name = "panel41";
            this.panel41.Size = new System.Drawing.Size(54, 41);
            this.panel41.TabIndex = 40;
            // 
            // panel42
            // 
            this.panel42.Location = new System.Drawing.Point(63, 191);
            this.panel42.Name = "panel42";
            this.panel42.Size = new System.Drawing.Size(54, 41);
            this.panel42.TabIndex = 41;
            // 
            // panel43
            // 
            this.panel43.Location = new System.Drawing.Point(123, 191);
            this.panel43.Name = "panel43";
            this.panel43.Size = new System.Drawing.Size(54, 41);
            this.panel43.TabIndex = 42;
            // 
            // panel44
            // 
            this.panel44.Location = new System.Drawing.Point(183, 191);
            this.panel44.Name = "panel44";
            this.panel44.Size = new System.Drawing.Size(54, 41);
            this.panel44.TabIndex = 43;
            // 
            // panel45
            // 
            this.panel45.Location = new System.Drawing.Point(243, 191);
            this.panel45.Name = "panel45";
            this.panel45.Size = new System.Drawing.Size(54, 41);
            this.panel45.TabIndex = 44;
            // 
            // panel46
            // 
            this.panel46.Location = new System.Drawing.Point(303, 191);
            this.panel46.Name = "panel46";
            this.panel46.Size = new System.Drawing.Size(54, 41);
            this.panel46.TabIndex = 45;
            // 
            // panel47
            // 
            this.panel47.Location = new System.Drawing.Point(363, 191);
            this.panel47.Name = "panel47";
            this.panel47.Size = new System.Drawing.Size(54, 41);
            this.panel47.TabIndex = 46;
            // 
            // panel48
            // 
            this.panel48.Location = new System.Drawing.Point(423, 191);
            this.panel48.Name = "panel48";
            this.panel48.Size = new System.Drawing.Size(54, 41);
            this.panel48.TabIndex = 47;
            // 
            // panel49
            // 
            this.panel49.Location = new System.Drawing.Point(483, 191);
            this.panel49.Name = "panel49";
            this.panel49.Size = new System.Drawing.Size(54, 41);
            this.panel49.TabIndex = 48;
            // 
            // panel50
            // 
            this.panel50.Location = new System.Drawing.Point(543, 191);
            this.panel50.Name = "panel50";
            this.panel50.Size = new System.Drawing.Size(62, 41);
            this.panel50.TabIndex = 49;
            // 
            // panel51
            // 
            this.panel51.Location = new System.Drawing.Point(3, 238);
            this.panel51.Name = "panel51";
            this.panel51.Size = new System.Drawing.Size(54, 41);
            this.panel51.TabIndex = 50;
            // 
            // panel52
            // 
            this.panel52.Location = new System.Drawing.Point(63, 238);
            this.panel52.Name = "panel52";
            this.panel52.Size = new System.Drawing.Size(54, 41);
            this.panel52.TabIndex = 51;
            // 
            // panel53
            // 
            this.panel53.Location = new System.Drawing.Point(123, 238);
            this.panel53.Name = "panel53";
            this.panel53.Size = new System.Drawing.Size(54, 41);
            this.panel53.TabIndex = 52;
            // 
            // panel54
            // 
            this.panel54.Location = new System.Drawing.Point(183, 238);
            this.panel54.Name = "panel54";
            this.panel54.Size = new System.Drawing.Size(54, 41);
            this.panel54.TabIndex = 53;
            // 
            // panel55
            // 
            this.panel55.Location = new System.Drawing.Point(243, 238);
            this.panel55.Name = "panel55";
            this.panel55.Size = new System.Drawing.Size(54, 41);
            this.panel55.TabIndex = 54;
            // 
            // panel56
            // 
            this.panel56.Location = new System.Drawing.Point(303, 238);
            this.panel56.Name = "panel56";
            this.panel56.Size = new System.Drawing.Size(54, 41);
            this.panel56.TabIndex = 55;
            // 
            // panel57
            // 
            this.panel57.Location = new System.Drawing.Point(363, 238);
            this.panel57.Name = "panel57";
            this.panel57.Size = new System.Drawing.Size(54, 41);
            this.panel57.TabIndex = 56;
            // 
            // panel58
            // 
            this.panel58.Location = new System.Drawing.Point(423, 238);
            this.panel58.Name = "panel58";
            this.panel58.Size = new System.Drawing.Size(54, 41);
            this.panel58.TabIndex = 57;
            // 
            // panel59
            // 
            this.panel59.Location = new System.Drawing.Point(483, 238);
            this.panel59.Name = "panel59";
            this.panel59.Size = new System.Drawing.Size(54, 41);
            this.panel59.TabIndex = 58;
            // 
            // panel60
            // 
            this.panel60.Location = new System.Drawing.Point(543, 238);
            this.panel60.Name = "panel60";
            this.panel60.Size = new System.Drawing.Size(62, 41);
            this.panel60.TabIndex = 59;
            // 
            // panel61
            // 
            this.panel61.Location = new System.Drawing.Point(3, 285);
            this.panel61.Name = "panel61";
            this.panel61.Size = new System.Drawing.Size(54, 41);
            this.panel61.TabIndex = 60;
            // 
            // panel62
            // 
            this.panel62.Location = new System.Drawing.Point(63, 285);
            this.panel62.Name = "panel62";
            this.panel62.Size = new System.Drawing.Size(54, 41);
            this.panel62.TabIndex = 61;
            // 
            // panel63
            // 
            this.panel63.Location = new System.Drawing.Point(123, 285);
            this.panel63.Name = "panel63";
            this.panel63.Size = new System.Drawing.Size(54, 41);
            this.panel63.TabIndex = 62;
            // 
            // panel64
            // 
            this.panel64.Location = new System.Drawing.Point(183, 285);
            this.panel64.Name = "panel64";
            this.panel64.Size = new System.Drawing.Size(54, 41);
            this.panel64.TabIndex = 63;
            // 
            // panel65
            // 
            this.panel65.Location = new System.Drawing.Point(243, 285);
            this.panel65.Name = "panel65";
            this.panel65.Size = new System.Drawing.Size(54, 41);
            this.panel65.TabIndex = 64;
            // 
            // panel66
            // 
            this.panel66.Location = new System.Drawing.Point(303, 285);
            this.panel66.Name = "panel66";
            this.panel66.Size = new System.Drawing.Size(54, 41);
            this.panel66.TabIndex = 65;
            // 
            // panel67
            // 
            this.panel67.Location = new System.Drawing.Point(363, 285);
            this.panel67.Name = "panel67";
            this.panel67.Size = new System.Drawing.Size(54, 41);
            this.panel67.TabIndex = 66;
            // 
            // panel68
            // 
            this.panel68.Location = new System.Drawing.Point(423, 285);
            this.panel68.Name = "panel68";
            this.panel68.Size = new System.Drawing.Size(54, 41);
            this.panel68.TabIndex = 67;
            // 
            // panel69
            // 
            this.panel69.Location = new System.Drawing.Point(483, 285);
            this.panel69.Name = "panel69";
            this.panel69.Size = new System.Drawing.Size(54, 41);
            this.panel69.TabIndex = 68;
            // 
            // panel70
            // 
            this.panel70.Location = new System.Drawing.Point(543, 285);
            this.panel70.Name = "panel70";
            this.panel70.Size = new System.Drawing.Size(62, 41);
            this.panel70.TabIndex = 69;
            // 
            // panel71
            // 
            this.panel71.Location = new System.Drawing.Point(3, 332);
            this.panel71.Name = "panel71";
            this.panel71.Size = new System.Drawing.Size(54, 41);
            this.panel71.TabIndex = 70;
            // 
            // panel72
            // 
            this.panel72.Location = new System.Drawing.Point(63, 332);
            this.panel72.Name = "panel72";
            this.panel72.Size = new System.Drawing.Size(54, 41);
            this.panel72.TabIndex = 71;
            // 
            // panel73
            // 
            this.panel73.Location = new System.Drawing.Point(123, 332);
            this.panel73.Name = "panel73";
            this.panel73.Size = new System.Drawing.Size(54, 41);
            this.panel73.TabIndex = 72;
            // 
            // panel74
            // 
            this.panel74.Location = new System.Drawing.Point(183, 332);
            this.panel74.Name = "panel74";
            this.panel74.Size = new System.Drawing.Size(54, 41);
            this.panel74.TabIndex = 73;
            // 
            // panel75
            // 
            this.panel75.Location = new System.Drawing.Point(243, 332);
            this.panel75.Name = "panel75";
            this.panel75.Size = new System.Drawing.Size(54, 41);
            this.panel75.TabIndex = 74;
            // 
            // panel76
            // 
            this.panel76.Location = new System.Drawing.Point(303, 332);
            this.panel76.Name = "panel76";
            this.panel76.Size = new System.Drawing.Size(54, 41);
            this.panel76.TabIndex = 75;
            // 
            // panel77
            // 
            this.panel77.Location = new System.Drawing.Point(363, 332);
            this.panel77.Name = "panel77";
            this.panel77.Size = new System.Drawing.Size(54, 41);
            this.panel77.TabIndex = 76;
            // 
            // panel78
            // 
            this.panel78.Location = new System.Drawing.Point(423, 332);
            this.panel78.Name = "panel78";
            this.panel78.Size = new System.Drawing.Size(54, 41);
            this.panel78.TabIndex = 77;
            // 
            // panel79
            // 
            this.panel79.Location = new System.Drawing.Point(483, 332);
            this.panel79.Name = "panel79";
            this.panel79.Size = new System.Drawing.Size(54, 41);
            this.panel79.TabIndex = 78;
            // 
            // panel80
            // 
            this.panel80.Location = new System.Drawing.Point(543, 332);
            this.panel80.Name = "panel80";
            this.panel80.Size = new System.Drawing.Size(62, 41);
            this.panel80.TabIndex = 79;
            // 
            // panel81
            // 
            this.panel81.Location = new System.Drawing.Point(3, 379);
            this.panel81.Name = "panel81";
            this.panel81.Size = new System.Drawing.Size(54, 41);
            this.panel81.TabIndex = 80;
            // 
            // panel82
            // 
            this.panel82.Location = new System.Drawing.Point(63, 379);
            this.panel82.Name = "panel82";
            this.panel82.Size = new System.Drawing.Size(54, 41);
            this.panel82.TabIndex = 81;
            // 
            // panel83
            // 
            this.panel83.Location = new System.Drawing.Point(123, 379);
            this.panel83.Name = "panel83";
            this.panel83.Size = new System.Drawing.Size(54, 41);
            this.panel83.TabIndex = 82;
            // 
            // panel84
            // 
            this.panel84.Location = new System.Drawing.Point(183, 379);
            this.panel84.Name = "panel84";
            this.panel84.Size = new System.Drawing.Size(54, 41);
            this.panel84.TabIndex = 83;
            // 
            // panel85
            // 
            this.panel85.Location = new System.Drawing.Point(243, 379);
            this.panel85.Name = "panel85";
            this.panel85.Size = new System.Drawing.Size(54, 41);
            this.panel85.TabIndex = 84;
            // 
            // panel86
            // 
            this.panel86.Location = new System.Drawing.Point(303, 379);
            this.panel86.Name = "panel86";
            this.panel86.Size = new System.Drawing.Size(54, 41);
            this.panel86.TabIndex = 85;
            // 
            // panel87
            // 
            this.panel87.Location = new System.Drawing.Point(363, 379);
            this.panel87.Name = "panel87";
            this.panel87.Size = new System.Drawing.Size(54, 41);
            this.panel87.TabIndex = 86;
            // 
            // panel88
            // 
            this.panel88.Location = new System.Drawing.Point(423, 379);
            this.panel88.Name = "panel88";
            this.panel88.Size = new System.Drawing.Size(54, 41);
            this.panel88.TabIndex = 87;
            // 
            // panel89
            // 
            this.panel89.Location = new System.Drawing.Point(483, 379);
            this.panel89.Name = "panel89";
            this.panel89.Size = new System.Drawing.Size(54, 41);
            this.panel89.TabIndex = 88;
            // 
            // panel90
            // 
            this.panel90.Location = new System.Drawing.Point(543, 379);
            this.panel90.Name = "panel90";
            this.panel90.Size = new System.Drawing.Size(62, 41);
            this.panel90.TabIndex = 89;
            // 
            // panel91
            // 
            this.panel91.Location = new System.Drawing.Point(3, 426);
            this.panel91.Name = "panel91";
            this.panel91.Size = new System.Drawing.Size(54, 50);
            this.panel91.TabIndex = 90;
            // 
            // panel92
            // 
            this.panel92.Location = new System.Drawing.Point(63, 426);
            this.panel92.Name = "panel92";
            this.panel92.Size = new System.Drawing.Size(54, 50);
            this.panel92.TabIndex = 91;
            // 
            // panel93
            // 
            this.panel93.Location = new System.Drawing.Point(123, 426);
            this.panel93.Name = "panel93";
            this.panel93.Size = new System.Drawing.Size(54, 50);
            this.panel93.TabIndex = 92;
            // 
            // panel94
            // 
            this.panel94.Location = new System.Drawing.Point(183, 426);
            this.panel94.Name = "panel94";
            this.panel94.Size = new System.Drawing.Size(54, 50);
            this.panel94.TabIndex = 93;
            // 
            // panel95
            // 
            this.panel95.Location = new System.Drawing.Point(243, 426);
            this.panel95.Name = "panel95";
            this.panel95.Size = new System.Drawing.Size(54, 50);
            this.panel95.TabIndex = 94;
            // 
            // panel96
            // 
            this.panel96.Location = new System.Drawing.Point(303, 426);
            this.panel96.Name = "panel96";
            this.panel96.Size = new System.Drawing.Size(54, 50);
            this.panel96.TabIndex = 95;
            // 
            // panel97
            // 
            this.panel97.Location = new System.Drawing.Point(363, 426);
            this.panel97.Name = "panel97";
            this.panel97.Size = new System.Drawing.Size(54, 50);
            this.panel97.TabIndex = 96;
            // 
            // panel98
            // 
            this.panel98.Location = new System.Drawing.Point(423, 426);
            this.panel98.Name = "panel98";
            this.panel98.Size = new System.Drawing.Size(54, 50);
            this.panel98.TabIndex = 97;
            // 
            // panel99
            // 
            this.panel99.Location = new System.Drawing.Point(483, 426);
            this.panel99.Name = "panel99";
            this.panel99.Size = new System.Drawing.Size(54, 50);
            this.panel99.TabIndex = 98;
            // 
            // panel100
            // 
            this.panel100.Location = new System.Drawing.Point(543, 426);
            this.panel100.Name = "panel100";
            this.panel100.Size = new System.Drawing.Size(62, 50);
            this.panel100.TabIndex = 99;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 503);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.KeyDown += this.Form1_KeyDown;
            panels = new List<List<System.Windows.Forms.Panel>>()
            {
                new List<System.Windows.Forms.Panel>(){panel1, panel2, panel3, panel4, panel5, panel6, panel7, panel8, panel9, panel10},
                new List<System.Windows.Forms.Panel>(){panel11, panel12, panel13, panel14, panel15, panel16, panel17, panel18, panel19, panel20},
                new List<System.Windows.Forms.Panel>(){panel21, panel22, panel23, panel24, panel25, panel26, panel27, panel28, panel29, panel30},
                new List<System.Windows.Forms.Panel>(){panel31, panel32, panel33, panel34, panel35, panel36, panel37, panel38, panel39, panel40},
                new List<System.Windows.Forms.Panel>(){panel41, panel42, panel43, panel44, panel45, panel46, panel47, panel48, panel49, panel50},
                new List<System.Windows.Forms.Panel>(){panel51, panel52, panel53, panel54, panel55, panel56, panel57, panel58, panel59, panel60},
                new List<System.Windows.Forms.Panel>(){panel61, panel62, panel63, panel64, panel65, panel66, panel67, panel68, panel69, panel70},
                new List<System.Windows.Forms.Panel>(){panel71, panel72, panel73, panel74, panel75, panel76, panel77, panel78, panel79, panel80},
                new List<System.Windows.Forms.Panel>(){panel81, panel82, panel83, panel84, panel85, panel86, panel87, panel88, panel89, panel90},
                new List<System.Windows.Forms.Panel>(){panel91, panel92, panel93, panel94, panel95, panel96, panel97, panel98, panel99, panel100}
                
            };
            Thread th = new Thread(new ThreadStart(StartGame));
            th.Start();
            
        }

        public Queue<char> KeyBuffer = new Queue<char>();
        #endregion
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                KeyBuffer.Enqueue('u');
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                KeyBuffer.Enqueue('d');
            }
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                KeyBuffer.Enqueue('l');
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                KeyBuffer.Enqueue('r');
            }
        }

        private void StartGame()
        {
            Thread.Sleep(1000);
            KeyBuffer.Enqueue('u');
            playGame();

        }
        public void playGame()
        {
            
            Game game = new Game();
            game.PlayGame(this);
            
        }
        public List<List<System.Windows.Forms.Panel>> panels = new List<List<System.Windows.Forms.Panel>>();
        
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.Panel panel34;
        private System.Windows.Forms.Panel panel35;
        private System.Windows.Forms.Panel panel36;
        private System.Windows.Forms.Panel panel37;
        private System.Windows.Forms.Panel panel38;
        private System.Windows.Forms.Panel panel39;
        private System.Windows.Forms.Panel panel40;
        private System.Windows.Forms.Panel panel41;
        private System.Windows.Forms.Panel panel42;
        private System.Windows.Forms.Panel panel43;
        private System.Windows.Forms.Panel panel44;
        private System.Windows.Forms.Panel panel45;
        private System.Windows.Forms.Panel panel46;
        private System.Windows.Forms.Panel panel47;
        private System.Windows.Forms.Panel panel48;
        private System.Windows.Forms.Panel panel49;
        private System.Windows.Forms.Panel panel50;
        private System.Windows.Forms.Panel panel51;
        private System.Windows.Forms.Panel panel52;
        private System.Windows.Forms.Panel panel53;
        private System.Windows.Forms.Panel panel54;
        private System.Windows.Forms.Panel panel55;
        private System.Windows.Forms.Panel panel56;
        private System.Windows.Forms.Panel panel57;
        private System.Windows.Forms.Panel panel58;
        private System.Windows.Forms.Panel panel59;
        private System.Windows.Forms.Panel panel60;
        private System.Windows.Forms.Panel panel61;
        private System.Windows.Forms.Panel panel62;
        private System.Windows.Forms.Panel panel63;
        private System.Windows.Forms.Panel panel64;
        private System.Windows.Forms.Panel panel65;
        private System.Windows.Forms.Panel panel66;
        private System.Windows.Forms.Panel panel67;
        private System.Windows.Forms.Panel panel68;
        private System.Windows.Forms.Panel panel69;
        private System.Windows.Forms.Panel panel70;
        private System.Windows.Forms.Panel panel71;
        private System.Windows.Forms.Panel panel72;
        private System.Windows.Forms.Panel panel73;
        private System.Windows.Forms.Panel panel74;
        private System.Windows.Forms.Panel panel75;
        private System.Windows.Forms.Panel panel76;
        private System.Windows.Forms.Panel panel77;
        private System.Windows.Forms.Panel panel78;
        private System.Windows.Forms.Panel panel79;
        private System.Windows.Forms.Panel panel80;
        private System.Windows.Forms.Panel panel81;
        private System.Windows.Forms.Panel panel82;
        private System.Windows.Forms.Panel panel83;
        private System.Windows.Forms.Panel panel84;
        private System.Windows.Forms.Panel panel85;
        private System.Windows.Forms.Panel panel86;
        private System.Windows.Forms.Panel panel87;
        private System.Windows.Forms.Panel panel88;
        private System.Windows.Forms.Panel panel89;
        private System.Windows.Forms.Panel panel90;
        private System.Windows.Forms.Panel panel91;
        private System.Windows.Forms.Panel panel92;
        private System.Windows.Forms.Panel panel93;
        private System.Windows.Forms.Panel panel94;
        private System.Windows.Forms.Panel panel95;
        private System.Windows.Forms.Panel panel96;
        private System.Windows.Forms.Panel panel97;
        private System.Windows.Forms.Panel panel98;
        private System.Windows.Forms.Panel panel99;
        private System.Windows.Forms.Panel panel100;
    }
}

