
namespace Theater.Client
{
    partial class Bill
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "", "Ghế thường", "70", "2", "140" }, -1);
            ListViewItem listViewItem2 = new ListViewItem("");
            lbName = new Label();
            tbxDate = new TextBox();
            lbDate = new Label();
            tbxTheater = new TextBox();
            lbTheater = new Label();
            tbxSeat = new TextBox();
            lbSeat = new Label();
            tbxPrice = new TextBox();
            lbPrice = new Label();
            lbTicInfo = new Label();
            lvPrice = new ListView();
            head0 = new ColumnHeader();
            head1 = new ColumnHeader();
            head2 = new ColumnHeader();
            head3 = new ColumnHeader();
            head4 = new ColumnHeader();
            btnAccept = new Button();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.Dock = DockStyle.Top;
            lbName.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbName.Location = new Point(6, 6);
            lbName.Margin = new Padding(4, 0, 4, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(357, 54);
            lbName.TabIndex = 0;
            lbName.Text = "<Tên phim>";
            lbName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxDate
            // 
            tbxDate.Dock = DockStyle.Top;
            tbxDate.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxDate.Location = new Point(6, 85);
            tbxDate.Margin = new Padding(4, 3, 4, 3);
            tbxDate.Name = "tbxDate";
            tbxDate.ReadOnly = true;
            tbxDate.Size = new Size(357, 31);
            tbxDate.TabIndex = 3;
            tbxDate.TextAlign = HorizontalAlignment.Center;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Dock = DockStyle.Top;
            lbDate.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDate.Location = new Point(6, 60);
            lbDate.Margin = new Padding(4, 0, 4, 0);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(132, 25);
            lbDate.TabIndex = 2;
            lbDate.Text = "Ngày chiếu: ";
            // 
            // tbxTheater
            // 
            tbxTheater.Dock = DockStyle.Top;
            tbxTheater.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxTheater.Location = new Point(6, 141);
            tbxTheater.Margin = new Padding(4, 3, 4, 3);
            tbxTheater.Name = "tbxTheater";
            tbxTheater.ReadOnly = true;
            tbxTheater.Size = new Size(357, 31);
            tbxTheater.TabIndex = 5;
            tbxTheater.TextAlign = HorizontalAlignment.Center;
            // 
            // lbTheater
            // 
            lbTheater.AutoSize = true;
            lbTheater.Dock = DockStyle.Top;
            lbTheater.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTheater.Location = new Point(6, 116);
            lbTheater.Margin = new Padding(4, 0, 4, 0);
            lbTheater.Name = "lbTheater";
            lbTheater.Size = new Size(115, 25);
            lbTheater.TabIndex = 4;
            lbTheater.Text = "Rạp chiếu:";
            // 
            // tbxSeat
            // 
            tbxSeat.Dock = DockStyle.Top;
            tbxSeat.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSeat.Location = new Point(6, 197);
            tbxSeat.Margin = new Padding(4, 3, 4, 3);
            tbxSeat.Name = "tbxSeat";
            tbxSeat.ReadOnly = true;
            tbxSeat.Size = new Size(357, 31);
            tbxSeat.TabIndex = 7;
            tbxSeat.TextAlign = HorizontalAlignment.Center;
            // 
            // lbSeat
            // 
            lbSeat.AutoSize = true;
            lbSeat.Dock = DockStyle.Top;
            lbSeat.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSeat.Location = new Point(6, 172);
            lbSeat.Margin = new Padding(4, 0, 4, 0);
            lbSeat.Name = "lbSeat";
            lbSeat.Size = new Size(111, 25);
            lbSeat.TabIndex = 6;
            lbSeat.Text = "Hàng ghế:";
            // 
            // tbxPrice
            // 
            tbxPrice.Dock = DockStyle.Top;
            tbxPrice.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPrice.Location = new Point(6, 253);
            tbxPrice.Margin = new Padding(4, 3, 4, 3);
            tbxPrice.Name = "tbxPrice";
            tbxPrice.ReadOnly = true;
            tbxPrice.Size = new Size(357, 31);
            tbxPrice.TabIndex = 9;
            tbxPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Dock = DockStyle.Top;
            lbPrice.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPrice.Location = new Point(6, 228);
            lbPrice.Margin = new Padding(4, 0, 4, 0);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(80, 25);
            lbPrice.TabIndex = 8;
            lbPrice.Text = "Giá vé:";
            // 
            // lbTicInfo
            // 
            lbTicInfo.AutoSize = true;
            lbTicInfo.Dock = DockStyle.Top;
            lbTicInfo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTicInfo.Location = new Point(6, 284);
            lbTicInfo.Margin = new Padding(4, 0, 4, 0);
            lbTicInfo.Name = "lbTicInfo";
            lbTicInfo.Size = new Size(137, 25);
            lbTicInfo.TabIndex = 11;
            lbTicInfo.Text = "Thông tin vé:";
            // 
            // lvPrice
            // 
            lvPrice.AutoArrange = false;
            lvPrice.Columns.AddRange(new ColumnHeader[] { head0, head1, head2, head3, head4 });
            lvPrice.Dock = DockStyle.Top;
            lvPrice.FullRowSelect = true;
            lvPrice.GridLines = true;
            lvPrice.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvPrice.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            lvPrice.Location = new Point(6, 309);
            lvPrice.Margin = new Padding(4, 3, 4, 3);
            lvPrice.Name = "lvPrice";
            lvPrice.Scrollable = false;
            lvPrice.Size = new Size(357, 137);
            lvPrice.TabIndex = 12;
            lvPrice.UseCompatibleStateImageBehavior = false;
            lvPrice.View = View.Details;
            // 
            // head0
            // 
            head0.DisplayIndex = 4;
            head0.Text = "";
            // 
            // head1
            // 
            head1.DisplayIndex = 0;
            head1.Text = "Loại vé";
            head1.Width = 81;
            // 
            // head2
            // 
            head2.DisplayIndex = 1;
            head2.Text = "Đơn giá";
            head2.Width = 49;
            // 
            // head3
            // 
            head3.DisplayIndex = 2;
            head3.Text = "Số lượng";
            head3.Width = 58;
            // 
            // head4
            // 
            head4.DisplayIndex = 3;
            head4.Text = "Thành tiền";
            head4.Width = 74;
            // 
            // btnAccept
            // 
            btnAccept.AutoSize = true;
            btnAccept.Dock = DockStyle.Top;
            btnAccept.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccept.Location = new Point(6, 446);
            btnAccept.Margin = new Padding(4, 3, 4, 3);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(357, 45);
            btnAccept.TabIndex = 13;
            btnAccept.Text = "XÁC NHẬN";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 537);
            Controls.Add(btnAccept);
            Controls.Add(lvPrice);
            Controls.Add(lbTicInfo);
            Controls.Add(tbxPrice);
            Controls.Add(lbPrice);
            Controls.Add(tbxSeat);
            Controls.Add(lbSeat);
            Controls.Add(tbxTheater);
            Controls.Add(lbTheater);
            Controls.Add(tbxDate);
            Controls.Add(lbDate);
            Controls.Add(lbName);
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Bill";
            Padding = new Padding(6);
            Text = "Info";
            FormClosing += Bill_FormClosing;
            Load += Bill_Load;
            KeyDown += Bill_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbxDate;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox tbxTheater;
        private System.Windows.Forms.Label lbTheater;
        private System.Windows.Forms.TextBox tbxSeat;
        private System.Windows.Forms.Label lbSeat;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbTicInfo;
        private System.Windows.Forms.ListView lvPrice;
        private System.Windows.Forms.ColumnHeader head0;
        private System.Windows.Forms.ColumnHeader head1;
        private System.Windows.Forms.ColumnHeader head2;
        private System.Windows.Forms.ColumnHeader head3;
        private System.Windows.Forms.ColumnHeader head4;
        private System.Windows.Forms.Button btnAccept;
    }
}