
namespace ApplicationCotLechTamPhang
{
    partial class frm_chon_Vat_lieu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_chon_Vat_lieu));
            this.DataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Label3 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btn_chon_thep = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_chon_betong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_lop_bao_ve = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.btn_ok = new System.Windows.Forms.GroupBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.GunaAdvenceButton6 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.groupBox1.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            this.btn_ok.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewImageColumn1
            // 
            this.DataGridViewImageColumn1.FillWeight = 40F;
            this.DataGridViewImageColumn1.HeaderText = "";
            this.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1";
            this.DataGridViewImageColumn1.ReadOnly = true;
            this.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewImageColumn1.ToolTipText = "Sửa thông tin nhân viên!";
            this.DataGridViewImageColumn1.Width = 45;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label3.Location = new System.Drawing.Point(28, 16);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(139, 20);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "1. CHỌN VẬT LIỆU";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // btn_chon_thep
            // 
            this.btn_chon_thep.BackColor = System.Drawing.Color.Transparent;
            this.btn_chon_thep.BorderRadius = 3;
            this.btn_chon_thep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.btn_chon_thep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.btn_chon_thep.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_chon_thep.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_chon_thep.FocusedState.Parent = this.btn_chon_thep;
            this.btn_chon_thep.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_chon_thep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.btn_chon_thep.HoverState.Parent = this.btn_chon_thep;
            this.btn_chon_thep.ItemHeight = 30;
            this.btn_chon_thep.Items.AddRange(new object[] {
            "CB-240-T",
            "CB-300-V"});
            this.btn_chon_thep.ItemsAppearance.Parent = this.btn_chon_thep;
            this.btn_chon_thep.Location = new System.Drawing.Point(88, 363);
            this.btn_chon_thep.Name = "btn_chon_thep";
            this.btn_chon_thep.ShadowDecoration.Parent = this.btn_chon_thep;
            this.btn_chon_thep.Size = new System.Drawing.Size(389, 36);
            this.btn_chon_thep.TabIndex = 21;
            this.btn_chon_thep.SelectedIndexChanged += new System.EventHandler(this.btn_chon_thep_SelectedIndexChanged);
            // 
            // btn_chon_betong
            // 
            this.btn_chon_betong.BackColor = System.Drawing.Color.Transparent;
            this.btn_chon_betong.BorderRadius = 3;
            this.btn_chon_betong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.btn_chon_betong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.btn_chon_betong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_chon_betong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_chon_betong.FocusedState.Parent = this.btn_chon_betong;
            this.btn_chon_betong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_chon_betong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.btn_chon_betong.HoverState.Parent = this.btn_chon_betong;
            this.btn_chon_betong.ItemHeight = 30;
            this.btn_chon_betong.Items.AddRange(new object[] {
            "Bê tông B20",
            "Bê tông B25"});
            this.btn_chon_betong.ItemsAppearance.Parent = this.btn_chon_betong;
            this.btn_chon_betong.Location = new System.Drawing.Point(30, 128);
            this.btn_chon_betong.Name = "btn_chon_betong";
            this.btn_chon_betong.ShadowDecoration.Parent = this.btn_chon_betong;
            this.btn_chon_betong.Size = new System.Drawing.Size(389, 36);
            this.btn_chon_betong.TabIndex = 22;
            this.btn_chon_betong.SelectedIndexChanged += new System.EventHandler(this.btn_chon_betong_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(76, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "2. Chọn Thép.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(89, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Khi đường kính thép lớn hơn 10 có thể chọn CII hoặc AII";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(85, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Thép chịu lực thường chọn C-I hoặc A-I. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(70, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "1. Chọn Bê Tông.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(85, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Với bản: Thép cấu tạo thường chọn thép C-I hoặc A-I";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(79, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "(Nội lực càng lớn thì chọn cấp bền càng lớn)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(79, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(399, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Thường dùng bê tông nặng có cấp độ bền theo cường độ chịu nén B15,B20,B25..";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_lop_bao_ve);
            this.groupBox1.Controls.Add(this.btn_chon_betong);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(44, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 472);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(51, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(273, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Nếu không chọn, lớp bảo vệ sẽ lấy 15 mm";
            // 
            // txt_lop_bao_ve
            // 
            this.txt_lop_bao_ve.BorderRadius = 5;
            this.txt_lop_bao_ve.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_lop_bao_ve.DefaultText = "";
            this.txt_lop_bao_ve.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_lop_bao_ve.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_lop_bao_ve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_lop_bao_ve.DisabledState.Parent = this.txt_lop_bao_ve;
            this.txt_lop_bao_ve.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_lop_bao_ve.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_lop_bao_ve.FocusedState.Parent = this.txt_lop_bao_ve;
            this.txt_lop_bao_ve.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lop_bao_ve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.txt_lop_bao_ve.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_lop_bao_ve.HoverState.Parent = this.txt_lop_bao_ve;
            this.txt_lop_bao_ve.Location = new System.Drawing.Point(50, 414);
            this.txt_lop_bao_ve.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_lop_bao_ve.Name = "txt_lop_bao_ve";
            this.txt_lop_bao_ve.PasswordChar = '\0';
            this.txt_lop_bao_ve.PlaceholderText = "Nhập lớp bảo vệ";
            this.txt_lop_bao_ve.SelectedText = "";
            this.txt_lop_bao_ve.ShadowDecoration.Parent = this.txt_lop_bao_ve;
            this.txt_lop_bao_ve.Size = new System.Drawing.Size(200, 26);
            this.txt_lop_bao_ve.TabIndex = 13;
            this.txt_lop_bao_ve.TextChanged += new System.EventHandler(this.txt_lop_bao_ve_TextChanged);
            this.txt_lop_bao_ve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_lop_bao_ve_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(40, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "3. Chọn lớp bảo vệ:";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(381, 522);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(112, 33);
            this.guna2Button1.TabIndex = 24;
            this.guna2Button1.Text = "OK";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaElipsePanel1.Controls.Add(this.GunaAdvenceButton6);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(534, 24);
            this.gunaElipsePanel1.TabIndex = 25;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.btn_ok.Controls.Add(this.Label3);
            this.btn_ok.Controls.Add(this.guna2Button1);
            this.btn_ok.Location = new System.Drawing.Point(12, 30);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(512, 573);
            this.btn_ok.TabIndex = 26;
            this.btn_ok.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.gunaElipsePanel1;
            // 
            // GunaAdvenceButton6
            // 
            this.GunaAdvenceButton6.AnimationHoverSpeed = 0.07F;
            this.GunaAdvenceButton6.AnimationSpeed = 0.03F;
            this.GunaAdvenceButton6.BaseColor = System.Drawing.Color.Transparent;
            this.GunaAdvenceButton6.BorderColor = System.Drawing.Color.Black;
            this.GunaAdvenceButton6.CheckedBaseColor = System.Drawing.Color.Gray;
            this.GunaAdvenceButton6.CheckedBorderColor = System.Drawing.Color.Black;
            this.GunaAdvenceButton6.CheckedForeColor = System.Drawing.Color.White;
            this.GunaAdvenceButton6.CheckedImage = ((System.Drawing.Image)(resources.GetObject("GunaAdvenceButton6.CheckedImage")));
            this.GunaAdvenceButton6.CheckedLineColor = System.Drawing.Color.DimGray;
            this.GunaAdvenceButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GunaAdvenceButton6.FocusedColor = System.Drawing.Color.Empty;
            this.GunaAdvenceButton6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GunaAdvenceButton6.ForeColor = System.Drawing.Color.White;
            this.GunaAdvenceButton6.Image = ((System.Drawing.Image)(resources.GetObject("GunaAdvenceButton6.Image")));
            this.GunaAdvenceButton6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GunaAdvenceButton6.ImageSize = new System.Drawing.Size(17, 17);
            this.GunaAdvenceButton6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.GunaAdvenceButton6.Location = new System.Drawing.Point(477, 0);
            this.GunaAdvenceButton6.Name = "GunaAdvenceButton6";
            this.GunaAdvenceButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(181)))), ((int)(((byte)(66)))));
            this.GunaAdvenceButton6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.GunaAdvenceButton6.OnHoverForeColor = System.Drawing.Color.White;
            this.GunaAdvenceButton6.OnHoverImage = null;
            this.GunaAdvenceButton6.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.GunaAdvenceButton6.OnPressedColor = System.Drawing.Color.Black;
            this.GunaAdvenceButton6.Size = new System.Drawing.Size(47, 24);
            this.GunaAdvenceButton6.TabIndex = 3;
            this.GunaAdvenceButton6.Click += new System.EventHandler(this.GunaAdvenceButton6_Click);
            // 
            // frm_chon_Vat_lieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(534, 615);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.btn_chon_thep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_chon_Vat_lieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.btn_ok.ResumeLayout(false);
            this.btn_ok.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.DataGridViewImageColumn DataGridViewImageColumn1;
        internal System.Windows.Forms.Label Label3;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI2.WinForms.Guna2ComboBox btn_chon_thep;
        private Guna.UI2.WinForms.Guna2ComboBox btn_chon_betong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txt_lop_bao_ve;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        internal Guna.UI.WinForms.GunaAdvenceButton GunaAdvenceButton6;
        private System.Windows.Forms.GroupBox btn_ok;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}