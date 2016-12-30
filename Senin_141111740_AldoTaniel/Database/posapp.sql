-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 26 Des 2016 pada 13.56
-- Versi Server: 10.1.16-MariaDB
-- PHP Version: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `posapp`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `account`
--

CREATE TABLE `account` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `level` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `account`
--

INSERT INTO `account` (`id`, `username`, `password`, `level`) VALUES
(1, 'admin', 'admin', 'Master');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tblbarang`
--

CREATE TABLE `tblbarang` (
  `idbarang` int(11) NOT NULL,
  `kodeBarang` varchar(20) NOT NULL,
  `kodesuplier` varchar(50) NOT NULL,
  `namaBarang` varchar(100) NOT NULL,
  `jlhAwal` int(10) NOT NULL,
  `hrgHPP` int(11) NOT NULL,
  `hrgJual` int(11) NOT NULL,
  `created_at` datetime NOT NULL,
  `update_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tblbarang`
--

INSERT INTO `tblbarang` (`idbarang`, `kodeBarang`, `kodesuplier`, `namaBarang`, `jlhAwal`, `hrgHPP`, `hrgJual`, `created_at`, `update_at`) VALUES
(28, '001', '001', 'Pepsodent', 10, 2500, 5000, '2016-12-26 19:00:10', '2016-12-26 19:00:10'),
(29, '002', '001', 'Citato', 5, 5000, 6500, '2016-12-26 19:00:31', '2016-12-26 19:00:31');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tblcustomer`
--

CREATE TABLE `tblcustomer` (
  `idcust` int(11) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `alamat` varchar(255) NOT NULL,
  `kodepos` varchar(10) NOT NULL,
  `email` varchar(50) NOT NULL,
  `nohp` varchar(13) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tblcustomer`
--

INSERT INTO `tblcustomer` (`idcust`, `nama`, `alamat`, `kodepos`, `email`, `nohp`, `created_at`, `updated_at`) VALUES
(3, 'Indah', 'Jl Sukabumi ini', '25001', 'indah@gmail.com', '085206925484', '2016-12-26 19:03:09', '2016-12-26 19:15:15');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tblpembelian`
--

CREATE TABLE `tblpembelian` (
  `no` int(11) NOT NULL,
  `idpembelian` int(11) NOT NULL,
  `kodesuplier` varchar(50) NOT NULL,
  `nm_perusahaan` varchar(50) NOT NULL,
  `kodeBarang` varchar(20) NOT NULL,
  `namaBarang` varchar(100) NOT NULL,
  `hargaHPP` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `subtotal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tblpenjualan`
--

CREATE TABLE `tblpenjualan` (
  `idpenj` int(11) NOT NULL,
  `no` int(11) NOT NULL,
  `kodeBarang` varchar(20) NOT NULL,
  `namaBarang` varchar(100) NOT NULL,
  `hrgJual` int(11) NOT NULL,
  `jumlah` int(10) NOT NULL,
  `subtotal` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tblsuplier`
--

CREATE TABLE `tblsuplier` (
  `idsuplier` int(50) NOT NULL,
  `kodesuplier` varchar(50) NOT NULL,
  `nm_perusahaan` varchar(50) NOT NULL,
  `nama_contact` varchar(50) NOT NULL,
  `alamat` text NOT NULL,
  `kodepos` varchar(10) NOT NULL,
  `email` varchar(50) NOT NULL,
  `nohp` varchar(13) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tblsuplier`
--

INSERT INTO `tblsuplier` (`idsuplier`, `kodesuplier`, `nm_perusahaan`, `nama_contact`, `alamat`, `kodepos`, `email`, `nohp`, `created_at`, `updated_at`) VALUES
(2, '001', 'PT Suka aku lha', 'Andre', 'Jl Apa Aja', '50000', 'ada@gmail.com', '085206925484', '2016-12-23 15:44:31', '2016-12-26 18:54:48'),
(4, '002', 'PT Cinta Kasih', 'Satrianjaya', 'Jl Kuoje', '2000', 'aku@gmail.com', '085206925484', '2016-12-26 19:02:05', '2016-12-26 19:02:05');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbltransaksipembelian`
--

CREATE TABLE `tbltransaksipembelian` (
  `idtransaksipembelian` int(11) NOT NULL,
  `faktur_pembelian` varchar(50) NOT NULL,
  `kodesuplier` varchar(50) NOT NULL,
  `nm_perusahaan` varchar(50) NOT NULL,
  `kodeBarang` varchar(20) NOT NULL,
  `namaBarang` varchar(100) NOT NULL,
  `hargaHPP` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `total` int(11) NOT NULL,
  `tglpembelian` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbltransaksipembelian`
--

INSERT INTO `tbltransaksipembelian` (`idtransaksipembelian`, `faktur_pembelian`, `kodesuplier`, `nm_perusahaan`, `kodeBarang`, `namaBarang`, `hargaHPP`, `jumlah`, `total`, `tglpembelian`, `updated_at`) VALUES
(4, '2', '001', 'PT Suka aku lha', '0032', 'Cendol', 5000, 5, 25000, '2016-12-26 18:46:28', '2016-12-26 18:46:28'),
(5, '3', '001', 'PT Suka aku lha', '0032', 'Cendol', 5000, 5, 25000, '2016-12-26 18:47:38', '2016-12-26 18:47:38'),
(6, '4', '001', 'PT Suka aku lha', '001', 'Pepsodent', 2500, 3, 7500, '2016-12-26 19:21:38', '2016-12-26 19:21:38'),
(7, '4', '001', 'PT Suka aku lha', '002', 'Citato', 5000, 3, 15000, '2016-12-26 19:21:38', '2016-12-26 19:21:38'),
(8, '5', '001', 'PT Suka aku lha', '001', 'Pepsodent', 2500, 5, 12500, '2016-12-26 19:33:18', '2016-12-26 19:33:18');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbltransaksipenjualan`
--

CREATE TABLE `tbltransaksipenjualan` (
  `idtransaksi` int(50) NOT NULL,
  `faktur_penjualan` varchar(50) NOT NULL,
  `idcust` int(11) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `kodeBarang` varchar(20) NOT NULL,
  `namaBarang` varchar(100) NOT NULL,
  `hrgJual` int(11) NOT NULL,
  `jumlah` int(10) NOT NULL,
  `total` int(11) NOT NULL,
  `tglpenjualan` datetime NOT NULL,
  `updated_at` datetime NOT NULL,
  `status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbltransaksipenjualan`
--

INSERT INTO `tbltransaksipenjualan` (`idtransaksi`, `faktur_penjualan`, `idcust`, `nama`, `kodeBarang`, `namaBarang`, `hrgJual`, `jumlah`, `total`, `tglpenjualan`, `updated_at`, `status`) VALUES
(49, '0', 3, 'Indah', '001', 'Pepsodent', 5000, 3, 15000, '2016-12-26 19:19:01', '2016-12-26 19:19:01', 'Lunas'),
(50, '0', 3, 'Indah', '002', 'Citato', 6500, 3, 19500, '2016-12-26 19:19:01', '2016-12-26 19:19:01', 'Lunas');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblbarang`
--
ALTER TABLE `tblbarang`
  ADD PRIMARY KEY (`idbarang`);

--
-- Indexes for table `tblcustomer`
--
ALTER TABLE `tblcustomer`
  ADD PRIMARY KEY (`idcust`);

--
-- Indexes for table `tblpembelian`
--
ALTER TABLE `tblpembelian`
  ADD PRIMARY KEY (`idpembelian`);

--
-- Indexes for table `tblpenjualan`
--
ALTER TABLE `tblpenjualan`
  ADD PRIMARY KEY (`idpenj`);

--
-- Indexes for table `tblsuplier`
--
ALTER TABLE `tblsuplier`
  ADD PRIMARY KEY (`idsuplier`);

--
-- Indexes for table `tbltransaksipembelian`
--
ALTER TABLE `tbltransaksipembelian`
  ADD PRIMARY KEY (`idtransaksipembelian`);

--
-- Indexes for table `tbltransaksipenjualan`
--
ALTER TABLE `tbltransaksipenjualan`
  ADD PRIMARY KEY (`idtransaksi`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `account`
--
ALTER TABLE `account`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tblbarang`
--
ALTER TABLE `tblbarang`
  MODIFY `idbarang` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;
--
-- AUTO_INCREMENT for table `tblcustomer`
--
ALTER TABLE `tblcustomer`
  MODIFY `idcust` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `tblpembelian`
--
ALTER TABLE `tblpembelian`
  MODIFY `idpembelian` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT for table `tblpenjualan`
--
ALTER TABLE `tblpenjualan`
  MODIFY `idpenj` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `tblsuplier`
--
ALTER TABLE `tblsuplier`
  MODIFY `idsuplier` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `tbltransaksipembelian`
--
ALTER TABLE `tbltransaksipembelian`
  MODIFY `idtransaksipembelian` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `tbltransaksipenjualan`
--
ALTER TABLE `tbltransaksipenjualan`
  MODIFY `idtransaksi` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
