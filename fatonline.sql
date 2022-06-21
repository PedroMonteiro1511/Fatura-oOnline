-- --------------------------------------------------------
-- Anfitrião:                    localhost
-- Versão do servidor:           10.4.22-MariaDB - mariadb.org binary distribution
-- SO do servidor:               Win64
-- HeidiSQL Versão:              11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- A despejar estrutura para tabela fatonline.categorias
CREATE TABLE IF NOT EXISTS `categorias` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(255) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- A despejar dados para tabela fatonline.categorias: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `categorias` DISABLE KEYS */;
INSERT INTO `categorias` (`id`, `Nome`, `created_at`) VALUES
	(1, 'Sapatos', '2022-06-15 17:53:16');
INSERT INTO `categorias` (`id`, `Nome`, `created_at`) VALUES
	(2, 'Calças', '2022-06-17 11:37:26');
INSERT INTO `categorias` (`id`, `Nome`, `created_at`) VALUES
	(3, 'Ventoinhas', '2022-06-21 12:40:14');
/*!40000 ALTER TABLE `categorias` ENABLE KEYS */;

-- A despejar estrutura para tabela fatonline.marcas
CREATE TABLE IF NOT EXISTS `marcas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(255) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- A despejar dados para tabela fatonline.marcas: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `marcas` DISABLE KEYS */;
INSERT INTO `marcas` (`id`, `nome`, `created_at`) VALUES
	(1, 'Nike', '2022-06-15 16:42:35');
INSERT INTO `marcas` (`id`, `nome`, `created_at`) VALUES
	(2, 'Adidas', '2022-06-15 16:42:41');
INSERT INTO `marcas` (`id`, `nome`, `created_at`) VALUES
	(3, 'Gucci', '2022-06-21 12:32:12');
/*!40000 ALTER TABLE `marcas` ENABLE KEYS */;

-- A despejar estrutura para tabela fatonline.produtos
CREATE TABLE IF NOT EXISTS `produtos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(255) NOT NULL,
  `referencia` varchar(255) NOT NULL,
  `descricao` varchar(255) NOT NULL,
  `marca` varchar(255) NOT NULL,
  `categoria` varchar(255) NOT NULL,
  `subcategoria` varchar(255) NOT NULL,
  `preco` decimal(19,2) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

-- A despejar dados para tabela fatonline.produtos: ~8 rows (aproximadamente)
/*!40000 ALTER TABLE `produtos` DISABLE KEYS */;
INSERT INTO `produtos` (`id`, `nome`, `referencia`, `descricao`, `marca`, `categoria`, `subcategoria`, `preco`, `created_at`) VALUES
	(1, 'Produto1', '193', 'Descrição o produto 1', 'Marca1', 'Categoria1', 'Subcategoria2', 15.00, '2022-06-08 16:34:03');
INSERT INTO `produtos` (`id`, `nome`, `referencia`, `descricao`, `marca`, `categoria`, `subcategoria`, `preco`, `created_at`) VALUES
	(2, 'Produto Novo', '145', 'Produto Novinho', '1', '1', '0', 56.00, '2022-06-08 16:47:30');
INSERT INTO `produtos` (`id`, `nome`, `referencia`, `descricao`, `marca`, `categoria`, `subcategoria`, `preco`, `created_at`) VALUES
	(3, 'Outro', '1', 'Outro', '', '1', '1', 145.00, '2022-06-08 16:48:17');
INSERT INTO `produtos` (`id`, `nome`, `referencia`, `descricao`, `marca`, `categoria`, `subcategoria`, `preco`, `created_at`) VALUES
	(4, 'SIm', '1235', 'Sim', '2', '1', '0', 98.00, '2022-06-08 16:50:50');
INSERT INTO `produtos` (`id`, `nome`, `referencia`, `descricao`, `marca`, `categoria`, `subcategoria`, `preco`, `created_at`) VALUES
	(5, 'Something', '164', 'Something', 'Marca 2', 'Categoria 1', 'SubCat 3', 15.00, '2022-06-08 16:52:21');
INSERT INTO `produtos` (`id`, `nome`, `referencia`, `descricao`, `marca`, `categoria`, `subcategoria`, `preco`, `created_at`) VALUES
	(6, 'Produto Novo', '1245', 'Produto Novo', 'Marca 1', 'Categoria 3', 'SubCat 2', 152.00, '2022-06-09 15:23:55');
INSERT INTO `produtos` (`id`, `nome`, `referencia`, `descricao`, `marca`, `categoria`, `subcategoria`, `preco`, `created_at`) VALUES
	(7, 'teste3', '675', 'Teste3', 'Marca 3', 'Categoria 3', 'SubCat 3', 156.00, '2022-06-09 15:26:40');
INSERT INTO `produtos` (`id`, `nome`, `referencia`, `descricao`, `marca`, `categoria`, `subcategoria`, `preco`, `created_at`) VALUES
	(8, 'Produto Novo', '746', 'Desc produto Novo', 'Marca 1', 'Categoria 1', 'SubCat 1', 15.00, '2022-06-09 17:15:45');
INSERT INTO `produtos` (`id`, `nome`, `referencia`, `descricao`, `marca`, `categoria`, `subcategoria`, `preco`, `created_at`) VALUES
	(9, 'Produto WPF', 'WPF1', 'ProdutoWPF1', 'Marca 1', 'Categoria 1', 'SubCategoria 3', 154.00, '2022-06-15 16:34:43');
INSERT INTO `produtos` (`id`, `nome`, `referencia`, `descricao`, `marca`, `categoria`, `subcategoria`, `preco`, `created_at`) VALUES
	(10, 'Ventoinha', '#1', 'Ventoinha da Gucci', 'Gucci', 'Ventoinhas', 'Automática', 149.00, '2022-06-21 12:41:15');
/*!40000 ALTER TABLE `produtos` ENABLE KEYS */;

-- A despejar estrutura para tabela fatonline.subcategorias
CREATE TABLE IF NOT EXISTS `subcategorias` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_categoria` int(11) NOT NULL,
  `nome` varchar(255) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- A despejar dados para tabela fatonline.subcategorias: ~5 rows (aproximadamente)
/*!40000 ALTER TABLE `subcategorias` DISABLE KEYS */;
INSERT INTO `subcategorias` (`id`, `id_categoria`, `nome`, `created_at`) VALUES
	(1, 1, 'Rasos', '2022-06-15 18:03:38');
INSERT INTO `subcategorias` (`id`, `id_categoria`, `nome`, `created_at`) VALUES
	(2, 2, 'Jeans', '2022-06-17 12:49:41');
INSERT INTO `subcategorias` (`id`, `id_categoria`, `nome`, `created_at`) VALUES
	(3, 1, 'Salto-alto', '2022-06-20 17:52:01');
INSERT INTO `subcategorias` (`id`, `id_categoria`, `nome`, `created_at`) VALUES
	(4, 2, 'Skinny Jeans', '2022-06-20 18:00:09');
INSERT INTO `subcategorias` (`id`, `id_categoria`, `nome`, `created_at`) VALUES
	(5, 3, 'Automática', '2022-06-21 12:40:27');
/*!40000 ALTER TABLE `subcategorias` ENABLE KEYS */;

-- A despejar estrutura para tabela fatonline.users
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(255) NOT NULL,
  `Morada` varchar(255) NOT NULL,
  `Telefone` varchar(9) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `Email` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `Email` (`Email`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

-- A despejar dados para tabela fatonline.users: ~6 rows (aproximadamente)
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` (`id`, `Nome`, `Morada`, `Telefone`, `Password`, `created_at`, `Email`) VALUES
	(1, 'Pedro Monteiro', 'Rua 54', '918782326', 'pedromonteiro', '2022-06-17 15:45:56', 'email@email.pt');
INSERT INTO `users` (`id`, `Nome`, `Morada`, `Telefone`, `Password`, `created_at`, `Email`) VALUES
	(2, 'PEdro Teste', 'Rua 55', '123456789', '8I8rq2cFrGbrNtz00JNPrKZO++foqbZmwl854M+ZqH/+6sGF', '2022-06-17 16:02:18', 'email@email.teste');
INSERT INTO `users` (`id`, `Nome`, `Morada`, `Telefone`, `Password`, `created_at`, `Email`) VALUES
	(3, 'Noo User', 'RUa 87', '192837465', '8zzsSQ+XvfTnkOGuwyxUCprtoRVoNWO0DUk+gesXtCdQ7yBA', '2022-06-17 16:07:04', 'email@hash.pt');
INSERT INTO `users` (`id`, `Nome`, `Morada`, `Telefone`, `Password`, `created_at`, `Email`) VALUES
	(4, 'Pedro Novo Hash', 'Rua 76', '192837465', '$MYHASH$V1$10000$CZoYkiKlJVhJnjJoBN+ZQJWrcbP0v5bWI2tOOhIBG655HhI+', '2022-06-17 17:11:07', 'hash@teste.com');
INSERT INTO `users` (`id`, `Nome`, `Morada`, `Telefone`, `Password`, `created_at`, `Email`) VALUES
	(5, 'DBC', 'rua67', '195436872', '$MYHASH$V1$10000$cmlLr0LSbO00ux1hclqa++k7wyyfzZsMHpmcp7rkfW9Jyl1z', '2022-06-17 17:53:58', 'DBC@teste.com');
INSERT INTO `users` (`id`, `Nome`, `Morada`, `Telefone`, `Password`, `created_at`, `Email`) VALUES
	(6, 'PedroHash', 'Rua67', '918723645', '$MYHASH$V1$10000$9pT32CyYPi5MPyOVwTaurJFTM5oqLtkPIprK/VDy8kgir3fx', '2022-06-20 10:53:21', 'hash@teste.pt');
INSERT INTO `users` (`id`, `Nome`, `Morada`, `Telefone`, `Password`, `created_at`, `Email`) VALUES
	(7, 'duplicado', 'Rua 41', '918723645', '$MYHASH$V1$10000$UeUiBEDCe2/Fmgj7zDjdoqL1UJ4TX1ohegDjGriCVAUfyYsM', '2022-06-20 10:58:55', 'duplicado@teste.pt');
INSERT INTO `users` (`id`, `Nome`, `Morada`, `Telefone`, `Password`, `created_at`, `Email`) VALUES
	(8, 'Pedro Manuel Ferreira Monteiro', 'Rua 86 Porta 2', '918782326', '$MYHASH$V1$10000$gijkg9BtKalVyTjUsybsW6OVVVxZ80mNth5HrFKXwsg5j2n9', '2022-06-20 17:11:35', 'email@gmail.com');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
