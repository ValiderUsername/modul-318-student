namespace Meine_Transport_App
{
    partial class Form1
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
            this.UhrzeitTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DatumPicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchVerbindung = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.VerbindungenGrid = new System.Windows.Forms.DataGridView();
            this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fahrtdauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbfahrtsplanLabel = new System.Windows.Forms.Label();
            this.Abfahrtstafel = new System.Windows.Forms.DataGridView();
            this.Von = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EingabeVon = new System.Windows.Forms.ComboBox();
            this.EingabeNach = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.VerbindungslisteLabel = new System.Windows.Forms.Label();
            this.Mailvorlage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerbindungenGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abfahrtstafel)).BeginInit();
            this.SuspendLayout();
            // 
            // UhrzeitTextBox
            // 
            this.UhrzeitTextBox.Location = new System.Drawing.Point(372, 208);
            this.UhrzeitTextBox.Name = "UhrzeitTextBox";
            this.UhrzeitTextBox.Size = new System.Drawing.Size(110, 27);
            this.UhrzeitTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zeit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum";
            // 
            // DatumPicker
            // 
            this.DatumPicker.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatumPicker.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatumPicker.Location = new System.Drawing.Point(85, 213);
            this.DatumPicker.Name = "DatumPicker";
            this.DatumPicker.Size = new System.Drawing.Size(238, 22);
            this.DatumPicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(335, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Meine Transport App";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Von";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Meine_Transport_App.Properties.Resources.Zug;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Meine_Transport_App.Properties.Resources.Bus;
            this.pictureBox2.Location = new System.Drawing.Point(858, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nach";
            // 
            // SearchVerbindung
            // 
            this.SearchVerbindung.Location = new System.Drawing.Point(545, 149);
            this.SearchVerbindung.Name = "SearchVerbindung";
            this.SearchVerbindung.Size = new System.Drawing.Size(133, 29);
            this.SearchVerbindung.TabIndex = 11;
            this.SearchVerbindung.Text = "Suchen";
            this.SearchVerbindung.UseVisualStyleBackColor = true;
            this.SearchVerbindung.Click += new System.EventHandler(this.SearchVerbindungen);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Meine_Transport_App.Properties.Resources.Mail;
            this.pictureBox3.Location = new System.Drawing.Point(790, 149);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 91);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // VerbindungenGrid
            // 
            this.VerbindungenGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VerbindungenGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrt,
            this.Ankunft,
            this.Fahrtdauer,
            this.Gleis});
            this.VerbindungenGrid.Location = new System.Drawing.Point(12, 307);
            this.VerbindungenGrid.Name = "VerbindungenGrid";
            this.VerbindungenGrid.RowHeadersWidth = 51;
            this.VerbindungenGrid.RowTemplate.Height = 29;
            this.VerbindungenGrid.Size = new System.Drawing.Size(971, 157);
            this.VerbindungenGrid.TabIndex = 14;
            // 
            // Abfahrt
            // 
            this.Abfahrt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Abfahrt.HeaderText = "Abfahrt";
            this.Abfahrt.MinimumWidth = 6;
            this.Abfahrt.Name = "Abfahrt";
            this.Abfahrt.ReadOnly = true;
            // 
            // Ankunft
            // 
            this.Ankunft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ankunft.HeaderText = "Ankunft";
            this.Ankunft.MinimumWidth = 6;
            this.Ankunft.Name = "Ankunft";
            this.Ankunft.ReadOnly = true;
            // 
            // Fahrtdauer
            // 
            this.Fahrtdauer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fahrtdauer.HeaderText = "Fahrtdauer";
            this.Fahrtdauer.MinimumWidth = 6;
            this.Fahrtdauer.Name = "Fahrtdauer";
            this.Fahrtdauer.ReadOnly = true;
            // 
            // Gleis
            // 
            this.Gleis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gleis.HeaderText = "Gleis";
            this.Gleis.MinimumWidth = 6;
            this.Gleis.Name = "Gleis";
            this.Gleis.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AbfahrtsplanLabel
            // 
            this.AbfahrtsplanLabel.AutoSize = true;
            this.AbfahrtsplanLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AbfahrtsplanLabel.Location = new System.Drawing.Point(421, 467);
            this.AbfahrtsplanLabel.Name = "AbfahrtsplanLabel";
            this.AbfahrtsplanLabel.Size = new System.Drawing.Size(161, 29);
            this.AbfahrtsplanLabel.TabIndex = 15;
            this.AbfahrtsplanLabel.Text = "Abfahrtsplan";
            // 
            // Abfahrtstafel
            // 
            this.Abfahrtstafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Abfahrtstafel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Von,
            this.Nach,
            this.dataGridViewTextBoxColumn1});
            this.Abfahrtstafel.Location = new System.Drawing.Point(12, 499);
            this.Abfahrtstafel.Name = "Abfahrtstafel";
            this.Abfahrtstafel.RowHeadersWidth = 51;
            this.Abfahrtstafel.RowTemplate.Height = 29;
            this.Abfahrtstafel.Size = new System.Drawing.Size(971, 172);
            this.Abfahrtstafel.TabIndex = 16;
            // 
            // Von
            // 
            this.Von.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Von.HeaderText = "Von";
            this.Von.MinimumWidth = 6;
            this.Von.Name = "Von";
            this.Von.ReadOnly = true;
            // 
            // Nach
            // 
            this.Nach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nach.HeaderText = "Nach";
            this.Nach.MinimumWidth = 6;
            this.Nach.Name = "Nach";
            this.Nach.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Abfahrt";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // EingabeVon
            // 
            this.EingabeVon.FormattingEnabled = true;
            this.EingabeVon.Location = new System.Drawing.Point(85, 149);
            this.EingabeVon.Name = "EingabeVon";
            this.EingabeVon.Size = new System.Drawing.Size(202, 28);
            this.EingabeVon.TabIndex = 17;
            this.EingabeVon.DropDown += new System.EventHandler(this.EingabeVon_DropDown);
            // 
            // EingabeNach
            // 
            this.EingabeNach.FormattingEnabled = true;
            this.EingabeNach.Location = new System.Drawing.Point(321, 149);
            this.EingabeNach.Name = "EingabeNach";
            this.EingabeNach.Size = new System.Drawing.Size(202, 28);
            this.EingabeNach.TabIndex = 18;
            this.EingabeNach.DropDown += new System.EventHandler(this.EingabeNach_DropDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "Mit Datum und Zeit suchen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SearchFutureVerbindungen);
            // 
            // VerbindungslisteLabel
            // 
            this.VerbindungslisteLabel.AutoSize = true;
            this.VerbindungslisteLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VerbindungslisteLabel.Location = new System.Drawing.Point(403, 277);
            this.VerbindungslisteLabel.Name = "VerbindungslisteLabel";
            this.VerbindungslisteLabel.Size = new System.Drawing.Size(203, 27);
            this.VerbindungslisteLabel.TabIndex = 20;
            this.VerbindungslisteLabel.Text = "Verbindungsliste";
            // 
            // Mailvorlage
            // 
            this.Mailvorlage.Location = new System.Drawing.Point(790, 246);
            this.Mailvorlage.Name = "Mailvorlage";
            this.Mailvorlage.Size = new System.Drawing.Size(109, 29);
            this.Mailvorlage.TabIndex = 22;
            this.Mailvorlage.Text = "Mailvorlage";
            this.Mailvorlage.UseVisualStyleBackColor = true;
            this.Mailvorlage.Click += new System.EventHandler(this.Mailvorlage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 683);
            this.Controls.Add(this.Mailvorlage);
            this.Controls.Add(this.VerbindungslisteLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EingabeNach);
            this.Controls.Add(this.EingabeVon);
            this.Controls.Add(this.Abfahrtstafel);
            this.Controls.Add(this.AbfahrtsplanLabel);
            this.Controls.Add(this.VerbindungenGrid);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.SearchVerbindung);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DatumPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UhrzeitTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerbindungenGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abfahrtstafel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UhrzeitTextBox;
        private Label label1;
        private Label label2;
        private DateTimePicker DatumPicker;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label5;
        private Button SearchVerbindung;
        private PictureBox pictureBox3;
        private DataGridView VerbindungenGrid;
        private Label AbfahrtsplanLabel;
        private DataGridView Abfahrtstafel;
        private ComboBox EingabeVon;
        private ComboBox EingabeNach;
        private Button button1;
        private Label VerbindungslisteLabel;
        private Button Mailvorlage;
        private DataGridViewTextBoxColumn Von;
        private DataGridViewTextBoxColumn Nach;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Abfahrt;
        private DataGridViewTextBoxColumn Ankunft;
        private DataGridViewTextBoxColumn Fahrtdauer;
        private DataGridViewTextBoxColumn Gleis;
    }
}