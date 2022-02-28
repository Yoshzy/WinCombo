-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 28-Fev-2022 às 15:10
-- Versão do servidor: 10.4.22-MariaDB
-- versão do PHP: 7.3.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `combo`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cofrinho`
--

CREATE TABLE `cofrinho` (
  `id` int(6) UNSIGNED NOT NULL,
  `usuario` varchar(30) NOT NULL DEFAULT '0',
  `valor` bigint(50) NOT NULL DEFAULT 0,
  `meta` bigint(50) NOT NULL DEFAULT 0,
  `reg_date` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cofrinho`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `faturas`
--

CREATE TABLE `faturas` (
  `id` int(6) UNSIGNED NOT NULL,
  `nome` varchar(30) NOT NULL,
  `usuario` varchar(30) NOT NULL,
  `valor` varchar(50) DEFAULT NULL,
  `vencimento` varchar(50) DEFAULT NULL,
  `info` varchar(255) NOT NULL,
  `ano` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `faturas`
--

--
-- Estrutura da tabela `servicos`
--

CREATE TABLE `servicos` (
  `id` int(6) UNSIGNED NOT NULL,
  `nome` varchar(30) NOT NULL,
  `usuario` varchar(30) NOT NULL,
  `valor` varchar(50) DEFAULT NULL,
  `data` varchar(50) DEFAULT NULL,
  `info` varchar(255) NOT NULL,
  `ano` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `servicos`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `users`
--

CREATE TABLE `users` (
  `id` int(6) UNSIGNED NOT NULL,
  `nome` varchar(30) NOT NULL,
  `sobrenome` varchar(30) NOT NULL,
  `usuario` varchar(30) NOT NULL,
  `empresa` varchar(30) NOT NULL,
  `email` varchar(50) DEFAULT NULL,
  `senha` varchar(50) NOT NULL,
  `reg_date` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `img` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `users`
--

INSERT INTO `users` (`id`, `nome`, `sobrenome`, `usuario`, `empresa`, `email`, `senha`, `reg_date`, `img`) VALUES
(1, 'Alisson', 'Deh', 'izz', 'JosneySoft', 'alisson.cplus@gmail.com', '123456', '2022-02-26 13:34:29', 'https://i.imgur.com/UUaOEvy.jpg'),

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cofrinho`
--
ALTER TABLE `cofrinho`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `faturas`
--
ALTER TABLE `faturas`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `servicos`
--
ALTER TABLE `servicos`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cofrinho`
--
ALTER TABLE `cofrinho`
  MODIFY `id` int(6) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de tabela `faturas`
--
ALTER TABLE `faturas`
  MODIFY `id` int(6) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de tabela `servicos`
--
ALTER TABLE `servicos`
  MODIFY `id` int(6) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de tabela `users`
--
ALTER TABLE `users`
  MODIFY `id` int(6) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
