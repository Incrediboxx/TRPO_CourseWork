namespace TRPO_Kurs_Work
{
    partial class AdminModeForm
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
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FilmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idHall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.FilmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.namefilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Controls.Add(this.tabPage3);
            this.tab1.Location = new System.Drawing.Point(13, 13);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(571, 320);
            this.tab1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(563, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Фильмы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilmName,
            this.Duration});
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // FilmName
            // 
            this.FilmName.HeaderText = "Название фильма";
            this.FilmName.Name = "FilmName";
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Длительность";
            this.Duration.Name = "Duration";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(563, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Залы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHall,
            this.Capacity,
            this.Col,
            this.Row});
            this.dataGridView2.Location = new System.Drawing.Point(7, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(550, 264);
            this.dataGridView2.TabIndex = 0;
            // 
            // idHall
            // 
            this.idHall.HeaderText = "Номер зала";
            this.idHall.Name = "idHall";
            // 
            // Capacity
            // 
            this.Capacity.HeaderText = "Вместимость";
            this.Capacity.Name = "Capacity";
            // 
            // Col
            // 
            this.Col.HeaderText = "Количество рядов";
            this.Col.Name = "Col";
            // 
            // Row
            // 
            this.Row.HeaderText = "Мест в ряду";
            this.Row.Name = "Row";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namefilm,
            this.dur,
            this.hal,
            this.pri});
            this.dataGridView3.Location = new System.Drawing.Point(7, 7);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(550, 261);
            this.dataGridView3.TabIndex = 0;
            // 
            // FilmPrice
            // 
            this.FilmPrice.HeaderText = "Цена";
            this.FilmPrice.Name = "FilmPrice";
            // 
            // hallId
            // 
            this.hallId.HeaderText = "Номер зала";
            this.hallId.Name = "hallId";
            // 
            // DurationFilm
            // 
            this.DurationFilm.HeaderText = "Продолжительность";
            this.DurationFilm.Name = "DurationFilm";
            // 
            // name
            // 
            this.name.HeaderText = "Название";
            this.name.Name = "name";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(563, 294);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Сеансы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // namefilm
            // 
            this.namefilm.HeaderText = "Название";
            this.namefilm.Name = "namefilm";
            // 
            // dur
            // 
            this.dur.HeaderText = "Продолжительность";
            this.dur.Name = "dur";
            // 
            // hal
            // 
            this.hal.HeaderText = "Номер зала";
            this.hal.Name = "hal";
            // 
            // pri
            // 
            this.pri.HeaderText = "Цена";
            this.pri.Name = "pri";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(438, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 380);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tab1);
            this.Name = "AdminModeForm";
            this.Text = "AdminModeForm";
            this.Load += new System.EventHandler(this.AdminModeForm_Load);
            this.tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHall;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Row;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn namefilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dur;
        private System.Windows.Forms.DataGridViewTextBoxColumn hal;
        private System.Windows.Forms.DataGridViewTextBoxColumn pri;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Button button1;
    }
}