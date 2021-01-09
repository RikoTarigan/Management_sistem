-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 09 Jan 2021 pada 18.49
-- Versi server: 10.4.11-MariaDB
-- Versi PHP: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbmngtdev`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `menudepartment`
--

CREATE TABLE `menudepartment` (
  `id` int(11) NOT NULL,
  `id_menutop` int(11) NOT NULL,
  `GROUP_NM` varchar(255) NOT NULL,
  `MAPVAL2` varchar(255) NOT NULL,
  `FORM_NM` varchar(255) NOT NULL,
  `MENUTOP_NM` varchar(255) NOT NULL,
  `CREATE_DTTM` datetime NOT NULL,
  `MAPVAL1` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `menudepartment`
--

INSERT INTO `menudepartment` (`id`, `id_menutop`, `GROUP_NM`, `MAPVAL2`, `FORM_NM`, `MENUTOP_NM`, `CREATE_DTTM`, `MAPVAL1`) VALUES
(1, 1, 'User Management', 'User Acces', 'UserAcces', 'ADMIN', '2020-12-31 16:11:07', 'Management'),
(2, 1, 'User Management', 'User Detail', 'Users', 'ADMIN', '2020-12-31 16:07:19', 'Management'),
(6, 5, 'Entry', '', 'F050101', 'ENTRY', '2021-01-06 20:40:34', 'Entry Nasabah'),
(7, 5, 'Entry', '', 'F050102', 'ENTRY', '2021-01-06 20:43:22', 'Entry Jaminan'),
(8, 5, 'Entry', '', 'F050103', 'ENTRY', '2021-01-06 20:44:00', 'Tanda Terima Jaminan Keluar'),
(10, 5, 'Entry', '', 'F050104', 'ENTRY', '2021-01-06 20:44:00', 'Pengiriman Pinjaman'),
(11, 5, 'Entry', '', 'F050105', 'ENTRY', '2021-01-06 20:44:00', 'Register Pinjaman'),
(12, 5, 'Entry', '', 'F050106', 'ENTRY', '2021-01-06 20:44:00', 'Update Pinjaman'),
(13, 8, 'Data Collector', '', 'F080101', 'DATA KARYAWAN', '0000-00-00 00:00:00', ''),
(14, 8, 'Data Sales', '', 'F080102', 'DATA KARYAWAN', '0000-00-00 00:00:00', ''),
(15, 9, 'Harian', '', 'F090101', 'LAPORAN', '2021-01-06 21:22:51', ''),
(16, 9, 'Umur Piutang', '', 'F090102', 'LAPORAN', '2021-01-06 21:22:51', ''),
(17, 6, '', '', 'F060101', 'TAGIHAN', '2021-01-06 21:22:51', ''),
(18, 7, '', '', 'F070101', 'PENJUALAN', '2021-01-06 21:22:51', '');

-- --------------------------------------------------------

--
-- Struktur dari tabel `menutop`
--

CREATE TABLE `menutop` (
  `id` int(11) NOT NULL,
  `NAME` varchar(255) NOT NULL,
  `CREATE_DTTM` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `menutop`
--

INSERT INTO `menutop` (`id`, `NAME`, `CREATE_DTTM`) VALUES
(1, 'ADMIN', '2020-12-31 16:07:19'),
(2, 'COLLECTOR', '2020-12-31 16:07:49'),
(3, 'LAPORAN', '2020-12-31 16:08:05'),
(4, 'SIMPANAN', '2020-12-31 16:08:18'),
(5, 'ENTRY', '2021-01-06 20:37:28'),
(6, 'TAGIHAN', '2021-01-06 20:37:40'),
(7, 'PENJUALAN', '2021-01-06 20:37:55'),
(8, 'DATA KARYAWAN', '2021-01-06 20:38:05'),
(9, 'LAPORAN', '2021-01-06 20:38:19');

-- --------------------------------------------------------

--
-- Struktur dari tabel `nasabah`
--

CREATE TABLE `nasabah` (
  `id` int(11) NOT NULL,
  `NAMA_COSTUMER` varchar(255) NOT NULL,
  `NO_KTP` varchar(16) DEFAULT NULL,
  `NO_KK` varchar(16) DEFAULT NULL,
  `AGAMA` varchar(255) DEFAULT NULL,
  `TEMPAT_LAHIR` varchar(255) DEFAULT NULL,
  `TANGGAL_LAHIR` varchar(255) DEFAULT NULL,
  `JK` varchar(255) DEFAULT NULL,
  `ALAMAT_KTP` varchar(255) DEFAULT NULL,
  `ALAMAT_DOMISILI` varchar(255) DEFAULT NULL,
  `TELP` varchar(255) DEFAULT NULL,
  `PEKERJAAN` varchar(255) DEFAULT NULL,
  `NAMA_IBU_KANDUNG` varchar(255) DEFAULT NULL,
  `TANGGAL_LAHIR_IBU` varchar(255) DEFAULT NULL,
  `NAMA_USAHA` varchar(255) DEFAULT NULL,
  `ALAMAT_UsAHA` varchar(255) DEFAULT NULL,
  `JENIS_USAHA` varchar(255) DEFAULT NULL,
  `NAMA_BANK` varchar(255) DEFAULT NULL,
  `NO_REKENING` varchar(255) DEFAULT NULL,
  `NAMA_REKENING` varchar(255) DEFAULT NULL,
  `NAMA_SALES` varchar(255) DEFAULT NULL,
  `WILAYAH_AREA_TAGIH` varchar(255) DEFAULT NULL,
  `STATUS_APPL` varchar(255) DEFAULT NULL,
  `STATUS_MENIKAH` varchar(1) DEFAULT NULL,
  `NAMA_PASANGAN` varchar(255) DEFAULT NULL,
  `NO_KTP_PASANGAN` varchar(255) DEFAULT NULL,
  `ALAMAT_PASANGAN` varchar(255) DEFAULT NULL,
  `TELP_PASANGAN` varchar(255) DEFAULT NULL,
  `NO_ANGGOTA` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `nasabah`
--

INSERT INTO `nasabah` (`id`, `NAMA_COSTUMER`, `NO_KTP`, `NO_KK`, `AGAMA`, `TEMPAT_LAHIR`, `TANGGAL_LAHIR`, `JK`, `ALAMAT_KTP`, `ALAMAT_DOMISILI`, `TELP`, `PEKERJAAN`, `NAMA_IBU_KANDUNG`, `TANGGAL_LAHIR_IBU`, `NAMA_USAHA`, `ALAMAT_UsAHA`, `JENIS_USAHA`, `NAMA_BANK`, `NO_REKENING`, `NAMA_REKENING`, `NAMA_SALES`, `WILAYAH_AREA_TAGIH`, `STATUS_APPL`, `STATUS_MENIKAH`, `NAMA_PASANGAN`, `NO_KTP_PASANGAN`, `ALAMAT_PASANGAN`, `TELP_PASANGAN`, `NO_ANGGOTA`) VALUES
(1, 'Riko Adrianto Tarigan', '123456789', '00000', 'Kristen', 'Bandar Meriah', '05/06/1997 20:08:36', 'Laki-laki', 'Bandar Meriah', 'Jalan Haji usman Tangerang selatan', '081397896751', 'Software Enginerr', 'Natalia br Sembiring', '25/12/19972', 'Warnet Tarigan', 'Medan', 'warnet', 'BRI', '7787', 'Riko', '', '', '1', 'M', 'Batu Tarigan', '1', 'Bandar meriah 1', '1', 'P0001-2021011'),
(2, 'a', 'ajwld', 'awd', 'Islam', 'awdla', '09/01/2021 20:29:21', 'L', 'awdl', 'dalwmd', 'walwdmalw', 'ldmalwd', 'lmald', 'alwd', 'awmldw', 'law', '21', '', '', '', 'awldw', 'awa', 'New', 'M', 'alwmdaw', 'lmlamdla', 'lmlakwdmlw', 'awd', 'P0001-2021012'),
(3, 'a', 'ajwld', 'awd', 'Islam', 'awdla', '09/01/2021 20:29:21', 'L', 'awdl', 'dalwmd', 'walwdmalw', 'ldmalwd', 'lmald', 'alwd', 'awmldw', 'law', '21', '', '', '', 'awldw', 'awa', 'RO', 'M', 'alwmdaw', 'lmlamdla', 'lmlakwdmlw', 'awd', 'P0001-2021013');

-- --------------------------------------------------------

--
-- Struktur dari tabel `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `NIP` varchar(16) NOT NULL,
  `NAMA` varchar(255) NOT NULL,
  `ADDRESS` varchar(255) NOT NULL,
  `TELP` varchar(21) NOT NULL,
  `MENUACCES` varchar(255) NOT NULL,
  `USR_ACTIVE` varchar(1) NOT NULL,
  `PASSWORD` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `users`
--

INSERT INTO `users` (`id`, `NIP`, `NAMA`, `ADDRESS`, `TELP`, `MENUACCES`, `USR_ACTIVE`, `PASSWORD`) VALUES
(1, '1', 'Riko Adrianto Tarigan', 'Jalan Haji Usman', '081397896751', '5,6,7,8,9', '1', ''),
(2, '2', 'Test', '1', '1', '1,3', '1', '');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `menudepartment`
--
ALTER TABLE `menudepartment`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `menutop`
--
ALTER TABLE `menutop`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `nasabah`
--
ALTER TABLE `nasabah`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `menudepartment`
--
ALTER TABLE `menudepartment`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT untuk tabel `menutop`
--
ALTER TABLE `menutop`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT untuk tabel `nasabah`
--
ALTER TABLE `nasabah`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT untuk tabel `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
