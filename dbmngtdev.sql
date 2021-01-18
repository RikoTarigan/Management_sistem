-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 18 Jan 2021 pada 14.34
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
-- Struktur dari tabel `collector`
--

CREATE TABLE `collector` (
  `id` int(11) NOT NULL,
  `COLLECTOR_ID` varchar(255) NOT NULL,
  `NM_COLLECTOR` varchar(255) NOT NULL,
  `ALAMAT_COLLECTOR` varchar(255) NOT NULL,
  `TELP_COLLECTOR` varchar(255) NOT NULL,
  `IS_ACTIVE` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `collector`
--

INSERT INTO `collector` (`id`, `COLLECTOR_ID`, `NM_COLLECTOR`, `ALAMAT_COLLECTOR`, `TELP_COLLECTOR`, `IS_ACTIVE`) VALUES
(2, 'C/012021-1', 'Kim Jong Un', '0813-1423-5122', 'Jakarta', 1),
(3, 'C/012021-3', 'Jokowi Widodi', '0813-1235-1235', 'Medan', 1),
(4, 'C/012021-4', 'Vladimir Putin', '0813-1553-6231', 'Kalimantan', 1),
(5, 'C/012021-5', 'Ratu Elisabeth XIII', '0815-1512-1356', 'Amerika', 1),
(6, 'C/012021-6', 'Riko', '0812-5122-524', 'Medan', 1);

-- --------------------------------------------------------

--
-- Struktur dari tabel `jaminan`
--

CREATE TABLE `jaminan` (
  `id` int(11) NOT NULL,
  `NO_JAMINAN` varchar(255) NOT NULL,
  `JENIS_JAMINAN` varchar(255) NOT NULL,
  `NO_ANGGOTA` varchar(255) DEFAULT NULL,
  `TANGGAL_MASUK` varchar(255) NOT NULL DEFAULT current_timestamp(),
  `NAMA_BARANG` varchar(255) NOT NULL,
  `TIPE_BARANG` varchar(255) NOT NULL,
  `KET1` text NOT NULL,
  `KET2` text NOT NULL,
  `NAMA_COLLECTOR` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `jaminan`
--

INSERT INTO `jaminan` (`id`, `NO_JAMINAN`, `JENIS_JAMINAN`, `NO_ANGGOTA`, `TANGGAL_MASUK`, `NAMA_BARANG`, `TIPE_BARANG`, `KET1`, `KET2`, `NAMA_COLLECTOR`) VALUES
(1, 'AG001-P0001-2021011', 'Kendaraan', 'P0001-2021011', '10/01/2021 14:15:35', 'Supra', 'testing', 'testing', '', ''),
(2, 'AG001-P0001-2021011', 'Kendaraan', 'P0001-2021011', '10/01/2021 14:15:35', 'Supra', 'testing', 'testing', '', ''),
(3, 'AG003-P0001-2021011', 'Kendaraan', 'P0001-2021011', '10/01/2021 14:24:48', 'awd', 'dw', 'wdad', '', ''),
(4, 'AG004-P0001-2021012', 'Kendaraan', 'P0001-2021012', '10/01/2021 14:27:44', 'sda', 'asd', 'sdas', '', ''),
(5, 'AG004-P0001-2021012', 'Kendaraan', 'P0001-2021012', '10/01/2021 14:27:44', 'sda', 'asd', 'sdas', '', ''),
(6, 'AG006-P0001-2021011', 'Kendaraan', 'P0001-2021011', '10/01/2021 14:28:27', 'awd', 'wd', '', '', ''),
(7, 'AG007-P0001-2021012', 'Kendaraan', 'P0001-2021012', '10/01/2021 14:30:34', 'ad', 'wd', 'wd', '', ''),
(8, 'AG007-P0001-2021012', 'Kendaraan', 'P0001-2021012', '10/01/2021 14:30:34', 'ad', 'wd', 'wd', '', ''),
(9, 'AG009-P0001-2021012', 'Kendaraan', 'P0001-2021012', '10/01/2021 14:34:38', 'wda', 'wad', '', '', ''),
(10, 'AG0010-P0001-2021011', 'Kendaraan', 'P0001-2021011', '10/01/2021 14:36:27', 'daw', 'awdaw', '', '', ''),
(11, 'AG0011-P0001-2021011', 'Kendaraan', 'P0001-2021011', '10/01/2021 14:36:27', 'daw', 'awdaw', '', '', ''),
(12, 'AG0012-P0001-2021011', 'Kendaraan', 'P0001-2021011', '10/01/2021 14:40:15', 'wdaw', 'awd', '', '', '');

-- --------------------------------------------------------

--
-- Struktur dari tabel `jaminan_keluar`
--

CREATE TABLE `jaminan_keluar` (
  `id` int(11) NOT NULL,
  `NO_JAMINAN` varchar(255) NOT NULL,
  `JENIS_JAMINAN` varchar(255) NOT NULL,
  `NO_ANGGOTA` varchar(255) DEFAULT NULL,
  `TANGGAL_MASUK` varchar(255) NOT NULL DEFAULT current_timestamp(),
  `NAMA_BARANG` varchar(255) NOT NULL,
  `TIPE_BARANG` varchar(255) NOT NULL,
  `KET1` text NOT NULL,
  `KET2` text NOT NULL,
  `NAMA_COLLECTOR` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

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
-- Struktur dari tabel `pinjaman`
--

CREATE TABLE `pinjaman` (
  `id` int(11) NOT NULL,
  `NM_NASABAH` varchar(255) NOT NULL,
  `NM_SALES` varchar(255) NOT NULL,
  `NM_COLLECTOR` varchar(255) NOT NULL,
  `SALES_ID` varchar(255) NOT NULL,
  `COLLECTOR_ID` varchar(255) NOT NULL,
  `JLH_PINJAMAN` decimal(10,2) NOT NULL DEFAULT 0.00,
  `TIPE_PINJAMAN` varchar(100) NOT NULL,
  `JLH_TENOR` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `pinjaman`
--

INSERT INTO `pinjaman` (`id`, `NM_NASABAH`, `NM_SALES`, `NM_COLLECTOR`, `SALES_ID`, `COLLECTOR_ID`, `JLH_PINJAMAN`, `TIPE_PINJAMAN`, `JLH_TENOR`) VALUES
(1, 't', '2t', 't', 't', 't', '0.00', '', 99),
(2, 'a', 'Riko Adrianto Tarigan', 'Kim Jong Un', '', '', '0.00', '', 1),
(3, 'Riko Adrianto Tarigan', 'Riko Adrianto Tarigan', 'Kim Jong Un', '', '', '100000.00', '', 2),
(4, 'Riko Adrianto Tarigan', 'Riko Adrianto Tarigan', 'Kim Jong Un', '', '', '99999999.99', 'Harian', 3),
(5, 'Riko Adrianto Tarigan', 'Riko Adrianto Tarigan', 'Kim Jong Un', '', '', '99000000.00', 'Harian', 0),
(6, 'Riko Adrianto Tarigan', 'Riko Adrianto Tarigan', 'Kim Jong Un', '', '', '99999999.99', 'Harian', 0),
(7, 'Riko Adrianto Tarigan', 'Riko Adrianto Tarigan', 'Kim Jong Un', '', '', '0.00', 'Harian', 4),
(8, 'a', 'Riko Adrianto Tarigan', 'Kim Jong Un', '', '', '0.00', 'Harian', 0);

-- --------------------------------------------------------

--
-- Struktur dari tabel `sales`
--

CREATE TABLE `sales` (
  `id` int(11) NOT NULL,
  `SALES_ID` varchar(255) NOT NULL,
  `NM_SALES` varchar(255) NOT NULL,
  `ALAMAT_SALES` varchar(255) NOT NULL,
  `TELP_SALES` varchar(255) NOT NULL,
  `IS_ACTIVE` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `sales`
--

INSERT INTO `sales` (`id`, `SALES_ID`, `NM_SALES`, `ALAMAT_SALES`, `TELP_SALES`, `IS_ACTIVE`) VALUES
(25, 'S/012021-1', 'Riko Adrianto Tarigan', '0812-1234-5232', 'Jakarta', 1),
(26, 'S/012021-26', 'Tifanny Alford', '0813-1512-5124', 'Amerika', 1),
(27, 'S/012021-27', 'Justin Bibier', '0893-1321-2512', 'Canada', 1),
(28, 'S/012021-28', 'Lisa Black Pink', '0812-1235-1512', 'Korea', 1),
(29, 'S/012021-29', 'Lee Min Hoo', '0812-1252-1512', 'Korea', 0);

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
-- Indeks untuk tabel `collector`
--
ALTER TABLE `collector`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `jaminan`
--
ALTER TABLE `jaminan`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `jaminan_keluar`
--
ALTER TABLE `jaminan_keluar`
  ADD PRIMARY KEY (`id`);

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
-- Indeks untuk tabel `pinjaman`
--
ALTER TABLE `pinjaman`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `sales`
--
ALTER TABLE `sales`
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
-- AUTO_INCREMENT untuk tabel `collector`
--
ALTER TABLE `collector`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT untuk tabel `jaminan`
--
ALTER TABLE `jaminan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT untuk tabel `jaminan_keluar`
--
ALTER TABLE `jaminan_keluar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

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
-- AUTO_INCREMENT untuk tabel `pinjaman`
--
ALTER TABLE `pinjaman`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT untuk tabel `sales`
--
ALTER TABLE `sales`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT untuk tabel `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
