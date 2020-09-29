-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 29 Sep 2020 pada 07.06
-- Versi server: 10.4.13-MariaDB
-- Versi PHP: 7.3.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_posmiew`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `barang`
--

CREATE TABLE `barang` (
  `id` int(50) NOT NULL,
  `bid` varchar(150) NOT NULL,
  `nama` varchar(200) NOT NULL,
  `merk` varchar(150) NOT NULL,
  `stok` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `barang`
--

INSERT INTO `barang` (`id`, `bid`, `nama`, `merk`, `stok`) VALUES
(4, '8996001350843\r', 'Super Star', 'MYR', 15);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_kulakan`
--

CREATE TABLE `tbl_kulakan` (
  `id` int(11) NOT NULL,
  `bid` varchar(150) NOT NULL,
  `toko_kulak` varchar(255) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `harga_k` int(11) NOT NULL,
  `sub_harga` int(11) NOT NULL,
  `tanggal` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_kulakan`
--

INSERT INTO `tbl_kulakan` (`id`, `bid`, `toko_kulak`, `jumlah`, `harga_k`, `sub_harga`, `tanggal`) VALUES
(4, '8996001350843\r', '', 10, 1300, 13000, '2020-09-10 01:09:43'),
(5, '8996001350843\r', '', 5, 1100, 5500, '2020-09-28 01:12:08');

--
-- Trigger `tbl_kulakan`
--
DELIMITER $$
CREATE TRIGGER `autosum_stokbarang` AFTER INSERT ON `tbl_kulakan` FOR EACH ROW UPDATE barang SET barang.stok=(barang.stok+NEW.jumlah) WHERE barang.bid=NEW.bid
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_updateharga`
--

CREATE TABLE `tbl_updateharga` (
  `id` int(11) NOT NULL,
  `bid` varchar(150) NOT NULL,
  `harga_ecer` int(11) NOT NULL,
  `harga_bakul` int(11) NOT NULL,
  `tgl_update` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_updateharga`
--

INSERT INTO `tbl_updateharga` (`id`, `bid`, `harga_ecer`, `harga_bakul`, `tgl_update`) VALUES
(1, '8996001350843\r', 1500, 1400, '2020-09-10 01:11:28'),
(2, '8996001350843\r', 1500, 1350, '2020-09-28 01:12:08');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `uid` (`bid`);

--
-- Indeks untuk tabel `tbl_kulakan`
--
ALTER TABLE `tbl_kulakan`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fkbid_bidutama` (`bid`);

--
-- Indeks untuk tabel `tbl_updateharga`
--
ALTER TABLE `tbl_updateharga`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_bid_utama` (`bid`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `barang`
--
ALTER TABLE `barang`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT untuk tabel `tbl_kulakan`
--
ALTER TABLE `tbl_kulakan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT untuk tabel `tbl_updateharga`
--
ALTER TABLE `tbl_updateharga`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tbl_kulakan`
--
ALTER TABLE `tbl_kulakan`
  ADD CONSTRAINT `fkbid_bidutama` FOREIGN KEY (`bid`) REFERENCES `barang` (`bid`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `tbl_updateharga`
--
ALTER TABLE `tbl_updateharga`
  ADD CONSTRAINT `fk_bid_utama` FOREIGN KEY (`bid`) REFERENCES `barang` (`bid`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
