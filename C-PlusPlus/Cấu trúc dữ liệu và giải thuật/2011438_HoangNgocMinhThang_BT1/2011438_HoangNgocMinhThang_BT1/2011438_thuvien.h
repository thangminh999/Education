#define MAX 100

struct HocVien
{
	char maHV[8];
	char ho[10];
	char tenlot[10];
	char ten[10];
	char lop[6];
	int namSinh;
	double diemTB;
	int soTC;
};


int TapTin_MangCT(char *filename, HocVien a[MAX], int &n);
void TieuDe();
void Xuat_HV(HocVien p);
void Xuat_DSHV(HocVien a[MAX], int n);
void TimHV_TheoTen(char ten[10], HocVien a[MAX], int n);


int TapTin_MangCT(char *filename, HocVien a[MAX], int &n)
{
	ifstream in(filename);
	if (!in)
		return 0;
	n = 0;
	while (!in.eof())
	{
		in >> a[n].maHV;
		in >> a[n].ho;
		in >> a[n].tenlot;
		in >> a[n].ten;
		in >> a[n].lop;
		in >> a[n].namSinh;
		in >> a[n].diemTB;
		in >> a[n].soTC;
		n++;
	}
	in.close();
	return 1;
}

void TieuDe()
{
	int i;
	cout << "\n";
	cout << ':';
	for (i = 1; i <= 74; i++)
		cout << '=';
	cout << ':';
	cout << "\n";
	cout << setiosflags(ios::left);
	cout << ':';
	cout << setw(9) << "Ma HV"
		<< ':'
		<< setw(30) << " Ho Va Ten HocVien"
		<< ':'
		<< setw(10) << "Lop"
		<< ':'
		<< setw(6) << "NS"
		<< ':'
		<< setw(6) << "DTB"
		<< ':'
		<< setw(8) << "SoTC"
		<< ':';
	cout << "\n";
	cout << ':';
	for (i = 1; i <= 74; i++)
		cout << '=';
	cout << ':';
	cout << "\n";
}

void Xuat_HV(HocVien p)
{
	cout << ':';
	cout << setiosflags(ios::left)
		<< setw(9) << p.maHV
		<< ':'
		<< setw(10) << p.ho
		<< setw(10) << p.tenlot
		<< setw(10) << p.ten
		<< ':'
		<< setw(10) << p.lop
		<< ':'
		<< setw(6) << p.namSinh
		<< ':'
		<< setw(6) << setiosflags(ios::fixed) << setprecision(2) << p.diemTB
		<< ':'
		<< setw(8) << p.soTC
		<< ':';
}

void Xuat_DSHV(HocVien a[MAX], int n)
{
	int i;
	TieuDe();
	for (i = 0; i < n; i++)
	{
		Xuat_HV(a[i]);
		cout << '\n';
	}
	cout << ':';
	for (i = 1; i <= 74; i++)
		cout << '=';
	cout << ':';
	cout << "\n";
}


void TimHV_TheoTen(char ten[10], HocVien a[MAX], int n)
{
	int i, kq = -1;
	for (i = 0; i < n; i++)
		if (_stricmp(a[i].ten, ten) == 0)
		{
			kq = 1;
			break;
		}
	if (kq == -1)
		cout << "\nDS Khong Co ten Cua Hoc Vien : " << ten;
	else
	{
		cout << "\nDS Hien Co Ten Cua Hoc Vien Nay : " << ten;
		cout << endl;
		TieuDe();
		for (i = 0; i < n; i++)
			if (_stricmp(a[i].ten, ten) == 0)
			{
				cout << endl;
				Xuat_HV(a[i]);
			}
	}
}


void Tim_TheoNamSinhVaDiemTrungBinh(double dTB, int year, HocVien a[MAX], int n)
{
	int i, kq = -1;
	for (i = 0; i < n; i++)
	{
		if (a[i].diemTB == dTB && a[i].namSinh == year)
		{
			if (a[i].diemTB <= 6.2 && a[i].namSinh > 1993)
			{
				kq = 1;
				break;
			}

		}
	}
	if (kq == -1)
		cout << "\nDanh sach khong co ten sinh vien nao sinh nam : " << year << " diem trung binh " << dTB;
	else
	{
		cout << "\nthong tin sinh vien trong danh sach co  " << dTB << " va nam sinh " << year;
		cout << endl;
		TieuDe();
		for (i = 0; i < n; i++)
			if (a[i].diemTB == dTB && a[i].namSinh == year)
			{
				if (a[i].diemTB <= 6.2 && a[i].namSinh > 1993)
				{
					cout << endl;
					Xuat_HV(a[i]);
				}

			}
	}
}
void Tim_TheoLopVaSoTinChi(char lop1[10], int SoTChi, HocVien a[MAX], int n)
{
	int i, kq = -1;
	for (i = 0; i < n; i++)
	{
		if (_stricmp(a[i].lop, lop1) == 0 && a[i].soTC == SoTChi)
		{
			if (a[i].soTC > 41)
			{
				kq = 1;
				break;
			}

		}
	}
	if (kq == -1)
		cout << "\nDanh sach khong co ten sinh vien nao sinh lop: " << lop1 << " va so tin chi " << SoTChi;
	else
	{
		cout << "\nthong tin sinh vien trong danh sach co lop  " << lop1 << " va so tin chi " << SoTChi;
		cout << endl;
		TieuDe();
		for (i = 0; i < n; i++)
		{
			if (_stricmp(a[i].lop, lop1) == 0 && a[i].soTC == SoTChi)
			{
				if (a[i].soTC > 41)
				{
					cout << endl;
					Xuat_HV(a[i]);
					break;
				}

			}
		}
	}
}