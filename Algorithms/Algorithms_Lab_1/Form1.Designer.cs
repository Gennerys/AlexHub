namespace Algorithms_Lab_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Очистка = new System.Windows.Forms.Button();
            this.Сорт = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ключ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Значение = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Ключ1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Значение1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Пузырёк = new System.Windows.Forms.RadioButton();
            this.Быстрая = new System.Windows.Forms.RadioButton();
            this.Выбором = new System.Windows.Forms.RadioButton();
            this.Вставками = new System.Windows.Forms.RadioButton();
            this.Шелл = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите сортировку:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(525, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество действий:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(548, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "ЗАГРУЗИТЬ ФАЙЛ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Очистка
            // 
            this.Очистка.Location = new System.Drawing.Point(255, 230);
            this.Очистка.Name = "Очистка";
            this.Очистка.Size = new System.Drawing.Size(101, 52);
            this.Очистка.TabIndex = 8;
            this.Очистка.Text = "Очистка";
            this.Очистка.UseVisualStyleBackColor = true;
            this.Очистка.Click += new System.EventHandler(this.Очистка_Click);
            // 
            // Сорт
            // 
            this.Сорт.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Сорт.Location = new System.Drawing.Point(4, 230);
            this.Сорт.Name = "Сорт";
            this.Сорт.Size = new System.Drawing.Size(159, 46);
            this.Сорт.TabIndex = 9;
            this.Сорт.Text = "СОРТИРОВАТЬ";
            this.Сорт.UseVisualStyleBackColor = true;
            this.Сорт.Click += new System.EventHandler(this.Сорт_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ключ,
            this.Значение});
            this.dataGridView1.Location = new System.Drawing.Point(239, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(236, 148);
            this.dataGridView1.TabIndex = 10;
            // 
            // Ключ
            // 
            this.Ключ.HeaderText = "Ключ";
            this.Ключ.Name = "Ключ";
            // 
            // Значение
            // 
            this.Значение.HeaderText = "Значение";
            this.Значение.Name = "Значение";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ключ1,
            this.Значение1});
            this.dataGridView2.Location = new System.Drawing.Point(548, 9);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(236, 147);
            this.dataGridView2.TabIndex = 11;
            // 
            // Ключ1
            // 
            this.Ключ1.HeaderText = "Ключ";
            this.Ключ1.Name = "Ключ1";
            // 
            // Значение1
            // 
            this.Значение1.HeaderText = "Значение";
            this.Значение1.Name = "Значение1";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5});
            this.dataGridView3.Location = new System.Drawing.Point(311, 504);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(548, 48);
            this.dataGridView3.TabIndex = 12;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // c1
            // 
            this.c1.HeaderText = "Пузырёк";
            this.c1.Name = "c1";
            // 
            // c2
            // 
            this.c2.HeaderText = "Быстрая";
            this.c2.Name = "c2";
            // 
            // c3
            // 
            this.c3.HeaderText = "Выбором";
            this.c3.Name = "c3";
            // 
            // c4
            // 
            this.c4.HeaderText = "Вставками";
            this.c4.Name = "c4";
            // 
            // c5
            // 
            this.c5.HeaderText = "Шелла";
            this.c5.Name = "c5";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Turquoise;
            this.groupBox1.Controls.Add(this.Шелл);
            this.groupBox1.Controls.Add(this.Вставками);
            this.groupBox1.Controls.Add(this.Выбором);
            this.groupBox1.Controls.Add(this.Быстрая);
            this.groupBox1.Controls.Add(this.Пузырёк);
            this.groupBox1.Location = new System.Drawing.Point(4, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 157);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // Пузырёк
            // 
            this.Пузырёк.AutoSize = true;
            this.Пузырёк.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Пузырёк.Location = new System.Drawing.Point(7, 20);
            this.Пузырёк.Name = "Пузырёк";
            this.Пузырёк.Size = new System.Drawing.Size(74, 19);
            this.Пузырёк.TabIndex = 0;
            this.Пузырёк.TabStop = true;
            this.Пузырёк.Text = "Пузырёк";
            this.Пузырёк.UseVisualStyleBackColor = true;
            // 
            // Быстрая
            // 
            this.Быстрая.AutoSize = true;
            this.Быстрая.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Быстрая.Location = new System.Drawing.Point(8, 43);
            this.Быстрая.Name = "Быстрая";
            this.Быстрая.Size = new System.Drawing.Size(76, 19);
            this.Быстрая.TabIndex = 1;
            this.Быстрая.TabStop = true;
            this.Быстрая.Text = "Быстрая";
            this.Быстрая.UseVisualStyleBackColor = true;
            this.Быстрая.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Выбором
            // 
            this.Выбором.AutoSize = true;
            this.Выбором.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Выбором.Location = new System.Drawing.Point(8, 66);
            this.Выбором.Name = "Выбором";
            this.Выбором.Size = new System.Drawing.Size(79, 19);
            this.Выбором.TabIndex = 2;
            this.Выбором.TabStop = true;
            this.Выбором.Text = "Выбором";
            this.Выбором.UseVisualStyleBackColor = true;
            // 
            // Вставками
            // 
            this.Вставками.AutoSize = true;
            this.Вставками.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Вставками.Location = new System.Drawing.Point(8, 89);
            this.Вставками.Name = "Вставками";
            this.Вставками.Size = new System.Drawing.Size(89, 19);
            this.Вставками.TabIndex = 3;
            this.Вставками.TabStop = true;
            this.Вставками.Text = "Вставками";
            this.Вставками.UseVisualStyleBackColor = true;
            // 
            // Шелл
            // 
            this.Шелл.AutoSize = true;
            this.Шелл.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Шелл.Location = new System.Drawing.Point(9, 111);
            this.Шелл.Name = "Шелл";
            this.Шелл.Size = new System.Drawing.Size(64, 19);
            this.Шелл.TabIndex = 4;
            this.Шелл.TabStop = true;
            this.Шелл.Text = "Шелла";
            this.Шелл.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(299, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "До сортировки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(599, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "После сортировки";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(912, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1169, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 20);
            this.textBox2.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1169, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 55);
            this.button2.TabIndex = 19;
            this.button2.Text = "Быстрый последовательный поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(912, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 56);
            this.button3.TabIndex = 20;
            this.button3.Text = "Бинарный поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1169, 353);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 56);
            this.button4.TabIndex = 21;
            this.button4.Text = "Интерполирующий поиск";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(912, 353);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 56);
            this.button5.TabIndex = 22;
            this.button5.Text = "Последовательный поиск";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1038, 423);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 56);
            this.button6.TabIndex = 23;
            this.button6.Text = "Поиск Фибоначчи";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(898, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Введите ключ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1082, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Найденный элемент:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(4, 471);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(141, 81);
            this.button7.TabIndex = 26;
            this.button7.Text = "СПРАВКА";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Red;
            this.button8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button8.Location = new System.Drawing.Point(1212, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(87, 31);
            this.button8.TabIndex = 27;
            this.button8.Text = "ВЫХОД";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1302, 573);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Сорт);
            this.Controls.Add(this.Очистка);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Очистка;
        private System.Windows.Forms.Button Сорт;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ключ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Значение;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ключ1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Значение1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Шелл;
        private System.Windows.Forms.RadioButton Вставками;
        private System.Windows.Forms.RadioButton Выбором;
        private System.Windows.Forms.RadioButton Быстрая;
        private System.Windows.Forms.RadioButton Пузырёк;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

