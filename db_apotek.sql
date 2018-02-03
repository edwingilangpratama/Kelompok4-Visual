-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 03, 2018 at 12:16 PM
-- Server version: 10.1.26-MariaDB
-- PHP Version: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_apotek`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_obat`
--

CREATE TABLE `tbl_obat` (
  `id_obat` int(10) NOT NULL,
  `kode_obat` varchar(20) NOT NULL,
  `kategori_obat` varchar(20) NOT NULL,
  `nama_obat` varchar(20) NOT NULL,
  `stok_obat` int(20) NOT NULL,
  `harga_obat` int(20) NOT NULL,
  `keterangan` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_obat`
--

INSERT INTO `tbl_obat` (`id_obat`, `kode_obat`, `kategori_obat`, `nama_obat`, `stok_obat`, `harga_obat`, `keterangan`) VALUES
(1, 'B001', 'Kapsul', 'OBH Comix Batuk', 9, 6000, 'Dosis normal 3 x dalam 1 hari'),
(2, 'B002', 'Kapsul', 'Oskadon', 10, 5000, ''),
(3, 'B003', 'Cair', 'Obat Cacing', 2, 6000, 'Sip');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pegawai`
--

CREATE TABLE `tbl_pegawai` (
  `id_pegawai` int(15) NOT NULL,
  `kode_pegawai` varchar(50) DEFAULT NULL,
  `nama` varchar(25) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `no_telp` varchar(15) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `role` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_pegawai`
--

INSERT INTO `tbl_pegawai` (`id_pegawai`, `kode_pegawai`, `nama`, `alamat`, `no_telp`, `username`, `password`, `role`) VALUES
(1, 'A001', 'Wawan Riswanto', 'Cimahi', '08112300287', 'wawan', '12345', 'Admin'),
(2, 'A002', 'Edwin Gilang Pratama', 'Bandung', '081313452460', 'gilang', '12345', 'Admin'),
(3, 'A003', 'Andri Krisna Senjaya', 'Sumedang', '0813423210277', 'andri', '12345', 'Admin'),
(4, 'A004', 'Restuningsih', 'Karawang', '0813423210265', 'restu', '12345', 'Admin'),
(6, 'A006', 'Edward', 'Cibaduyut', '085765321', 'edward', '12345', 'Admin');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pelanggan`
--

CREATE TABLE `tbl_pelanggan` (
  `id_pelanggan` int(10) NOT NULL,
  `kode_pelanggan` varchar(20) NOT NULL,
  `nama` varchar(25) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `jenis_kelamin` varchar(10) NOT NULL,
  `no_telp` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_pelanggan`
--

INSERT INTO `tbl_pelanggan` (`id_pelanggan`, `kode_pelanggan`, `nama`, `alamat`, `jenis_kelamin`, `no_telp`) VALUES
(1, 'C001', 'Steven', 'Ciamis', 'Perempuan', '1266879893'),
(2, 'C002', 'Fransisco', 'France', 'Laki-Laki', '124334321'),
(3, 'C003', 'Restu', 'bandung', 'Perempuan', '056745632');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_periksa`
--

CREATE TABLE `tbl_periksa` (
  `id_periksa` int(20) NOT NULL,
  `id_pelanggan` int(20) NOT NULL,
  `keluhan` mediumtext NOT NULL,
  `keterangan` mediumtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_periksa`
--

INSERT INTO `tbl_periksa` (`id_periksa`, `id_pelanggan`, `keluhan`, `keterangan`) VALUES
(1, 2, 'panas tiris', '0');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_transaksi`
--

CREATE TABLE `tbl_transaksi` (
  `id_transaksi` int(10) NOT NULL,
  `id_pegawai` int(5) NOT NULL,
  `id_pelanggan` int(5) NOT NULL,
  `id_obat` int(5) NOT NULL,
  `jumlah` int(15) NOT NULL,
  `total` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_transaksi`
--

INSERT INTO `tbl_transaksi` (`id_transaksi`, `id_pegawai`, `id_pelanggan`, `id_obat`, `jumlah`, `total`) VALUES
(1, 1, 1, 2, 6, 90000),
(2, 2, 1, 3, 5, 30000),
(3, 2, 2, 2, 1, 1000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_obat`
--
ALTER TABLE `tbl_obat`
  ADD PRIMARY KEY (`id_obat`),
  ADD UNIQUE KEY `kode_obat` (`kode_obat`);

--
-- Indexes for table `tbl_pegawai`
--
ALTER TABLE `tbl_pegawai`
  ADD PRIMARY KEY (`id_pegawai`);

--
-- Indexes for table `tbl_pelanggan`
--
ALTER TABLE `tbl_pelanggan`
  ADD PRIMARY KEY (`id_pelanggan`),
  ADD UNIQUE KEY `kode_pelanggan` (`kode_pelanggan`);

--
-- Indexes for table `tbl_periksa`
--
ALTER TABLE `tbl_periksa`
  ADD PRIMARY KEY (`id_periksa`);

--
-- Indexes for table `tbl_transaksi`
--
ALTER TABLE `tbl_transaksi`
  ADD PRIMARY KEY (`id_transaksi`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_obat`
--
ALTER TABLE `tbl_obat`
  MODIFY `id_obat` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbl_pegawai`
--
ALTER TABLE `tbl_pegawai`
  MODIFY `id_pegawai` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tbl_pelanggan`
--
ALTER TABLE `tbl_pelanggan`
  MODIFY `id_pelanggan` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbl_periksa`
--
ALTER TABLE `tbl_periksa`
  MODIFY `id_periksa` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tbl_transaksi`
--
ALTER TABLE `tbl_transaksi`
  MODIFY `id_transaksi` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
