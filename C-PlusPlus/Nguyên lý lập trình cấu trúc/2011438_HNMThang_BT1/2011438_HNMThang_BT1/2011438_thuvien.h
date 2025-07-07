#define Space '\n'
#define TAB '\t'

void XuatND(int n);
void DemSoLuong(int n);
void SoDau(int n);
void Tong(int n);


void XuatND(int n) {
	int temp = 0;
	for (int i = 1; i <= n; i++) {
		cout << i << TAB;
		temp += 1;
		if (temp % 10 == 0)
			cout << Space;
	}
}


void DemSoLuong(int n) {
	int sum = 0;
	int temp = n;
	while (n > 0) {

		sum += 1;

		n = n / 10;

	}
	cout << temp << " co tat ca " << sum << " chu so " << '\n';
}

void SoDau(int n) {
	int sum;
	int j = n;
	while (n > 0) {
		sum = n % 10;
		n = n / 10;
	}

	cout << "So dau tien cua " << j << " la " << sum << '\n';

}

void Tong(int n) {
	int sum = 0;
	int j = n;
	while (n > 0) {
		int temp = n % 10;
		sum += temp;
		n = n / 10;
	}

	cout << "\n Tong cac so cua " << j << " la " << sum << '\n';

}