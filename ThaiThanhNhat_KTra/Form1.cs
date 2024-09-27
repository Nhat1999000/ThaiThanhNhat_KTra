namespace ThaiThanhNhat_KTra
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private List<SachGiaoKhoa> danhSachSachGiaoKhoa = new List<SachGiaoKhoa>();
        private List<SachThamKhao> danhSachSachThamKhao = new List<SachThamKhao>();



        private void btnThemSachGiaoKhoa_Click(object sender, EventArgs e)
        {
            if (danhSachSachGiaoKhoa.Count < 5)
            {
                var sach = new SachGiaoKhoa(txtTenSach.Text, txtTacGia.Text, decimal.Parse(txtGiaBan.Text), txtMonHoc.Text, txtTinhTrang.Text);
                danhSachSachGiaoKhoa.Add(sach);
                HienThiDanhSachSachGiaoKhoa();
            }
            else
            {
                MessageBox.Show("Đã đạt giới hạn 5 sách giáo khoa.");
            }
        }
        private void HienThiDanhSachSachGiaoKhoa()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = danhSachSachGiaoKhoa;
            danhSachSachGiaoKhoa.Sort((x, y) => x.GiaBan.CompareTo(y.GiaBan));
        }

        private void btnThemSachThamKhao_Click(object sender, EventArgs e)
        {

            if (danhSachSachThamKhao.Count < 5)
            {
                var sach = new SachThamKhao(txtTenSach.Text, txtTacGia.Text, decimal.Parse(txtGiaBan.Text), txtLinhVuc.Text, txtNhaXuatBan.Text);
                danhSachSachThamKhao.Add(sach);
                HienThiDanhSachSachThamKhao();
            }
            else
            {
                MessageBox.Show("Đã đạt giới hạn 5 sách tham khảo.");
            }
        }
        private void HienThiDanhSachSachThamKhao()
        {
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = danhSachSachThamKhao;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                var selectedSach = (SachGiaoKhoa)dataGridView2.CurrentRow.DataBoundItem;
                danhSachSachGiaoKhoa.Remove(selectedSach);
                HienThiDanhSachSachGiaoKhoa();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaSachThamKhao_Click(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow != null)
            {
                var selectedSach = (SachThamKhao)dataGridView3.CurrentRow.DataBoundItem;
                danhSachSachThamKhao.Remove(selectedSach);
                HienThiDanhSachSachThamKhao();
            }
        }

        private void btnSuaSachGiaoKhoa_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                var selectedSach = (SachGiaoKhoa)dataGridView2.CurrentRow.DataBoundItem;
                selectedSach.TenSach = txtTenSach.Text;
                selectedSach.TacGia = txtTacGia.Text;
                selectedSach.GiaBan = decimal.Parse(txtGiaBan.Text);
                selectedSach.MonHoc = txtMonHoc.Text;
                selectedSach.TinhTrang = txtTinhTrang.Text;

                if (selectedSach.TinhTrang == "Cũ")
                    selectedSach.GiaBan *= 0.8m;

                HienThiDanhSachSachGiaoKhoa();
            }
        }

    }
}
