namespace graph_lab2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BuildTheLetter = new System.Windows.Forms.Button();
            this.Transfer = new System.Windows.Forms.Button();
            this.textBoxMoveX = new System.Windows.Forms.TextBox();
            this.textBoxMoveY = new System.Windows.Forms.TextBox();
            this.textBoxMoveZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.transferTimer = new System.Windows.Forms.Timer(this.components);
            this.Reflect = new System.Windows.Forms.Button();
            this.checkBoxReflectX = new System.Windows.Forms.CheckBox();
            this.checkBoxReflectY = new System.Windows.Forms.CheckBox();
            this.checkBoxReflectZ = new System.Windows.Forms.CheckBox();
            this.Scale = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxScaleZ = new System.Windows.Forms.TextBox();
            this.textBoxScaleY = new System.Windows.Forms.TextBox();
            this.textBoxScaleX = new System.Windows.Forms.TextBox();
            this.scaleTimer = new System.Windows.Forms.Timer(this.components);
            this.checkBoxRotateZ = new System.Windows.Forms.CheckBox();
            this.checkBoxRotateY = new System.Windows.Forms.CheckBox();
            this.checkBoxRotateX = new System.Windows.Forms.CheckBox();
            this.Rotate = new System.Windows.Forms.Button();
            this.rotateTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxAlpha = new System.Windows.Forms.TextBox();
            this.Move = new System.Windows.Forms.Button();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxBeta = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxTurnY = new System.Windows.Forms.TextBox();
            this.Turn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxTurnX = new System.Windows.Forms.TextBox();
            this.textBoxTurnZ = new System.Windows.Forms.TextBox();
            this.turnTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Beige;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(673, 594);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BuildTheLetter
            // 
            this.BuildTheLetter.Location = new System.Drawing.Point(747, 12);
            this.BuildTheLetter.Name = "BuildTheLetter";
            this.BuildTheLetter.Size = new System.Drawing.Size(238, 35);
            this.BuildTheLetter.TabIndex = 1;
            this.BuildTheLetter.Text = "Построить фигуру";
            this.BuildTheLetter.UseVisualStyleBackColor = true;
            this.BuildTheLetter.Click += new System.EventHandler(this.BuildTheLetter_Click);
            // 
            // Transfer
            // 
            this.Transfer.Enabled = false;
            this.Transfer.Location = new System.Drawing.Point(6, 28);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(133, 35);
            this.Transfer.TabIndex = 2;
            this.Transfer.Text = "Переместить";
            this.Transfer.UseVisualStyleBackColor = true;
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // textBoxMoveX
            // 
            this.textBoxMoveX.Location = new System.Drawing.Point(6, 80);
            this.textBoxMoveX.Name = "textBoxMoveX";
            this.textBoxMoveX.Size = new System.Drawing.Size(100, 20);
            this.textBoxMoveX.TabIndex = 3;
            this.textBoxMoveX.Text = "0";
            // 
            // textBoxMoveY
            // 
            this.textBoxMoveY.Location = new System.Drawing.Point(6, 119);
            this.textBoxMoveY.Name = "textBoxMoveY";
            this.textBoxMoveY.Size = new System.Drawing.Size(100, 20);
            this.textBoxMoveY.TabIndex = 4;
            this.textBoxMoveY.Text = "0";
            // 
            // textBoxMoveZ
            // 
            this.textBoxMoveZ.Location = new System.Drawing.Point(6, 158);
            this.textBoxMoveZ.Name = "textBoxMoveZ";
            this.textBoxMoveZ.Size = new System.Drawing.Size(100, 20);
            this.textBoxMoveZ.TabIndex = 5;
            this.textBoxMoveZ.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Смещение по ОХ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Смещение по ОУ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Смещение по ОZ";
            // 
            // transferTimer
            // 
            this.transferTimer.Interval = 20;
            this.transferTimer.Tick += new System.EventHandler(this.transferTimer_Tick);
            // 
            // Reflect
            // 
            this.Reflect.Enabled = false;
            this.Reflect.Location = new System.Drawing.Point(6, 22);
            this.Reflect.Name = "Reflect";
            this.Reflect.Size = new System.Drawing.Size(133, 35);
            this.Reflect.TabIndex = 10;
            this.Reflect.Text = "Отразить";
            this.Reflect.UseVisualStyleBackColor = true;
            this.Reflect.Click += new System.EventHandler(this.Reflect_Click);
            // 
            // checkBoxReflectX
            // 
            this.checkBoxReflectX.AutoSize = true;
            this.checkBoxReflectX.Location = new System.Drawing.Point(20, 69);
            this.checkBoxReflectX.Name = "checkBoxReflectX";
            this.checkBoxReflectX.Size = new System.Drawing.Size(116, 17);
            this.checkBoxReflectX.TabIndex = 11;
            this.checkBoxReflectX.Text = "Относительно ОХ";
            this.checkBoxReflectX.UseVisualStyleBackColor = true;
            // 
            // checkBoxReflectY
            // 
            this.checkBoxReflectY.AutoSize = true;
            this.checkBoxReflectY.Location = new System.Drawing.Point(19, 92);
            this.checkBoxReflectY.Name = "checkBoxReflectY";
            this.checkBoxReflectY.Size = new System.Drawing.Size(117, 17);
            this.checkBoxReflectY.TabIndex = 12;
            this.checkBoxReflectY.Text = "Относительно ОУ";
            this.checkBoxReflectY.UseVisualStyleBackColor = true;
            // 
            // checkBoxReflectZ
            // 
            this.checkBoxReflectZ.AutoSize = true;
            this.checkBoxReflectZ.Location = new System.Drawing.Point(19, 115);
            this.checkBoxReflectZ.Name = "checkBoxReflectZ";
            this.checkBoxReflectZ.Size = new System.Drawing.Size(116, 17);
            this.checkBoxReflectZ.TabIndex = 13;
            this.checkBoxReflectZ.Text = "Относительно ОZ";
            this.checkBoxReflectZ.UseVisualStyleBackColor = true;
            // 
            // Scale
            // 
            this.Scale.Enabled = false;
            this.Scale.Location = new System.Drawing.Point(6, 26);
            this.Scale.Name = "Scale";
            this.Scale.Size = new System.Drawing.Size(133, 35);
            this.Scale.TabIndex = 14;
            this.Scale.Text = "Масштабировать";
            this.Scale.UseVisualStyleBackColor = true;
            this.Scale.Click += new System.EventHandler(this.Scale_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Масштабирование по ОZ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Масштабирование по ОУ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Масштабирование по ОХ";
            // 
            // textBoxScaleZ
            // 
            this.textBoxScaleZ.Location = new System.Drawing.Point(7, 158);
            this.textBoxScaleZ.Name = "textBoxScaleZ";
            this.textBoxScaleZ.Size = new System.Drawing.Size(100, 20);
            this.textBoxScaleZ.TabIndex = 17;
            this.textBoxScaleZ.Text = "1";
            // 
            // textBoxScaleY
            // 
            this.textBoxScaleY.Location = new System.Drawing.Point(7, 119);
            this.textBoxScaleY.Name = "textBoxScaleY";
            this.textBoxScaleY.Size = new System.Drawing.Size(100, 20);
            this.textBoxScaleY.TabIndex = 16;
            this.textBoxScaleY.Text = "1";
            // 
            // textBoxScaleX
            // 
            this.textBoxScaleX.Location = new System.Drawing.Point(5, 80);
            this.textBoxScaleX.Name = "textBoxScaleX";
            this.textBoxScaleX.Size = new System.Drawing.Size(100, 20);
            this.textBoxScaleX.TabIndex = 15;
            this.textBoxScaleX.Text = "1";
            // 
            // scaleTimer
            // 
            this.scaleTimer.Interval = 30;
            this.scaleTimer.Tick += new System.EventHandler(this.scaleTimer_Tick);
            // 
            // checkBoxRotateZ
            // 
            this.checkBoxRotateZ.AutoSize = true;
            this.checkBoxRotateZ.Location = new System.Drawing.Point(14, 109);
            this.checkBoxRotateZ.Name = "checkBoxRotateZ";
            this.checkBoxRotateZ.Size = new System.Drawing.Size(79, 17);
            this.checkBoxRotateZ.TabIndex = 24;
            this.checkBoxRotateZ.Text = "Вокруг ОZ";
            this.checkBoxRotateZ.UseVisualStyleBackColor = true;
            // 
            // checkBoxRotateY
            // 
            this.checkBoxRotateY.AutoSize = true;
            this.checkBoxRotateY.Location = new System.Drawing.Point(14, 86);
            this.checkBoxRotateY.Name = "checkBoxRotateY";
            this.checkBoxRotateY.Size = new System.Drawing.Size(80, 17);
            this.checkBoxRotateY.TabIndex = 23;
            this.checkBoxRotateY.Text = "Вокруг ОУ";
            this.checkBoxRotateY.UseVisualStyleBackColor = true;
            // 
            // checkBoxRotateX
            // 
            this.checkBoxRotateX.AutoSize = true;
            this.checkBoxRotateX.Location = new System.Drawing.Point(15, 63);
            this.checkBoxRotateX.Name = "checkBoxRotateX";
            this.checkBoxRotateX.Size = new System.Drawing.Size(79, 17);
            this.checkBoxRotateX.TabIndex = 22;
            this.checkBoxRotateX.Text = "Вокруг ОХ";
            this.checkBoxRotateX.UseVisualStyleBackColor = true;
            // 
            // Rotate
            // 
            this.Rotate.Enabled = false;
            this.Rotate.Location = new System.Drawing.Point(6, 22);
            this.Rotate.Name = "Rotate";
            this.Rotate.Size = new System.Drawing.Size(133, 35);
            this.Rotate.TabIndex = 21;
            this.Rotate.Text = "Вращать";
            this.Rotate.UseVisualStyleBackColor = true;
            this.Rotate.Click += new System.EventHandler(this.Rotate_Click);
            // 
            // rotateTimer
            // 
            this.rotateTimer.Interval = 15;
            this.rotateTimer.Tick += new System.EventHandler(this.rotateTimer_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Начальная скорость";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Угол c OX";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(12, 160);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpeed.TabIndex = 27;
            this.textBoxSpeed.Text = "20";
            // 
            // textBoxAlpha
            // 
            this.textBoxAlpha.Location = new System.Drawing.Point(12, 79);
            this.textBoxAlpha.Name = "textBoxAlpha";
            this.textBoxAlpha.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlpha.TabIndex = 26;
            this.textBoxAlpha.Text = "30";
            // 
            // Move
            // 
            this.Move.Enabled = false;
            this.Move.Location = new System.Drawing.Point(5, 19);
            this.Move.Name = "Move";
            this.Move.Size = new System.Drawing.Size(133, 35);
            this.Move.TabIndex = 25;
            this.Move.Text = "Бросить";
            this.Move.UseVisualStyleBackColor = true;
            this.Move.Click += new System.EventHandler(this.Move_Click);
            // 
            // moveTimer
            // 
            this.moveTimer.Interval = 20;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OldLace;
            this.groupBox1.Controls.Add(this.checkBoxReflectZ);
            this.groupBox1.Controls.Add(this.Reflect);
            this.groupBox1.Controls.Add(this.checkBoxReflectX);
            this.groupBox1.Controls.Add(this.checkBoxReflectY);
            this.groupBox1.Location = new System.Drawing.Point(706, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 145);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отражение фигуры";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.OldLace;
            this.groupBox2.Controls.Add(this.Transfer);
            this.groupBox2.Controls.Add(this.textBoxMoveX);
            this.groupBox2.Controls.Add(this.textBoxMoveY);
            this.groupBox2.Controls.Add(this.textBoxMoveZ);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(864, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 193);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Перемещение фигуры";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.OldLace;
            this.groupBox3.Controls.Add(this.Scale);
            this.groupBox3.Controls.Add(this.textBoxScaleX);
            this.groupBox3.Controls.Add(this.textBoxScaleY);
            this.groupBox3.Controls.Add(this.textBoxScaleZ);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(708, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 193);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Масштабирование";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.OldLace;
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textBoxBeta);
            this.groupBox4.Controls.Add(this.Move);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBoxAlpha);
            this.groupBox4.Controls.Add(this.textBoxSpeed);
            this.groupBox4.Location = new System.Drawing.Point(708, 406);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(148, 191);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Бросок в пространстве";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Угол c OZ";
            // 
            // textBoxBeta
            // 
            this.textBoxBeta.Location = new System.Drawing.Point(12, 118);
            this.textBoxBeta.Name = "textBoxBeta";
            this.textBoxBeta.Size = new System.Drawing.Size(100, 20);
            this.textBoxBeta.TabIndex = 30;
            this.textBoxBeta.Text = "30";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.OldLace;
            this.groupBox5.Controls.Add(this.Rotate);
            this.groupBox5.Controls.Add(this.checkBoxRotateX);
            this.groupBox5.Controls.Add(this.checkBoxRotateY);
            this.groupBox5.Controls.Add(this.checkBoxRotateZ);
            this.groupBox5.Location = new System.Drawing.Point(864, 255);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(150, 145);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Вращение фигуры";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Moccasin;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(133, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Z";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Moccasin;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(277, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Moccasin;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(589, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "X";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.OldLace;
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.textBoxTurnY);
            this.groupBox6.Controls.Add(this.Turn);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.textBoxTurnX);
            this.groupBox6.Controls.Add(this.textBoxTurnZ);
            this.groupBox6.Location = new System.Drawing.Point(864, 406);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(148, 191);
            this.groupBox6.TabIndex = 38;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Поворот на угол";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Вокруг ОУ";
            // 
            // textBoxTurnY
            // 
            this.textBoxTurnY.Location = new System.Drawing.Point(12, 118);
            this.textBoxTurnY.Name = "textBoxTurnY";
            this.textBoxTurnY.Size = new System.Drawing.Size(100, 20);
            this.textBoxTurnY.TabIndex = 30;
            this.textBoxTurnY.Text = "30";
            // 
            // Turn
            // 
            this.Turn.Enabled = false;
            this.Turn.Location = new System.Drawing.Point(5, 19);
            this.Turn.Name = "Turn";
            this.Turn.Size = new System.Drawing.Size(133, 35);
            this.Turn.TabIndex = 25;
            this.Turn.Text = "Повернуть";
            this.Turn.UseVisualStyleBackColor = true;
            this.Turn.Click += new System.EventHandler(this.Turn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Вокруг ОХ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Вокруг OZ";
            // 
            // textBoxTurnX
            // 
            this.textBoxTurnX.Location = new System.Drawing.Point(12, 79);
            this.textBoxTurnX.Name = "textBoxTurnX";
            this.textBoxTurnX.Size = new System.Drawing.Size(100, 20);
            this.textBoxTurnX.TabIndex = 26;
            this.textBoxTurnX.Text = "30";
            // 
            // textBoxTurnZ
            // 
            this.textBoxTurnZ.Location = new System.Drawing.Point(12, 160);
            this.textBoxTurnZ.Name = "textBoxTurnZ";
            this.textBoxTurnZ.Size = new System.Drawing.Size(100, 20);
            this.textBoxTurnZ.TabIndex = 27;
            this.textBoxTurnZ.Text = "20";
            // 
            // turnTimer
            // 
            this.turnTimer.Interval = 50;
            this.turnTimer.Tick += new System.EventHandler(this.turnTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1028, 617);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BuildTheLetter);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lab2_graph";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BuildTheLetter;
        private System.Windows.Forms.Button Transfer;
        private System.Windows.Forms.TextBox textBoxMoveX;
        private System.Windows.Forms.TextBox textBoxMoveY;
        private System.Windows.Forms.TextBox textBoxMoveZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer transferTimer;
        private System.Windows.Forms.Button Reflect;
        private System.Windows.Forms.CheckBox checkBoxReflectX;
        private System.Windows.Forms.CheckBox checkBoxReflectY;
        private System.Windows.Forms.CheckBox checkBoxReflectZ;
        private System.Windows.Forms.Button Scale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxScaleZ;
        private System.Windows.Forms.TextBox textBoxScaleY;
        private System.Windows.Forms.TextBox textBoxScaleX;
        private System.Windows.Forms.Timer scaleTimer;
        private System.Windows.Forms.CheckBox checkBoxRotateZ;
        private System.Windows.Forms.CheckBox checkBoxRotateY;
        private System.Windows.Forms.CheckBox checkBoxRotateX;
        private System.Windows.Forms.Button Rotate;
        private System.Windows.Forms.Timer rotateTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.TextBox textBoxAlpha;
        private System.Windows.Forms.Button Move;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxBeta;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxTurnY;
        private System.Windows.Forms.Button Turn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxTurnX;
        private System.Windows.Forms.TextBox textBoxTurnZ;
        private System.Windows.Forms.Timer turnTimer;
    }
}

