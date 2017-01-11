CREATE DATABASE  IF NOT EXISTS `locadoraveiculos` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `locadoraveiculos`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: locadoraveiculos
-- ------------------------------------------------------
-- Server version	5.7.12-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `carro`
--

DROP TABLE IF EXISTS `carro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `carro` (
  `car_id` int(11) NOT NULL AUTO_INCREMENT,
  `car_placa` varchar(20) NOT NULL,
  `car_modelo` varchar(45) NOT NULL,
  `car_marca` varchar(45) NOT NULL,
  `car_renavam` varchar(45) NOT NULL,
  `car_chassi` varchar(45) NOT NULL,
  `car_ano_fab` varchar(45) NOT NULL,
  `car_ano_mod` varchar(45) NOT NULL,
  `car_tipo` varchar(20) NOT NULL,
  `car_cor` varchar(45) NOT NULL,
  `car_num_portas` varchar(20) NOT NULL,
  `car_combustivel` varchar(45) NOT NULL,
  `car_km` varchar(20) NOT NULL,
  `car_cidade` varchar(45) NOT NULL,
  `car_uf` varchar(45) NOT NULL,
  `car_obs` varchar(45) NOT NULL,
  `car_idf_ativo` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`car_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carro`
--

LOCK TABLES `carro` WRITE;
/*!40000 ALTER TABLE `carro` DISABLE KEYS */;
INSERT INTO `carro` VALUES (1,'CNA-7972','Z4 Roadster M 3.0 V6 24V 343cv','BMW','53458340856','38298392839283928','2007','2007','3.0','Cinza','2','Etanol','50000','Santos','São Paulo ','Trocar oleo',NULL),(2,'BFB-3191','Uno Way Celebration','Fiat','48077784876','19919091319093091','2011','2012','1.4','Marrom/Bege','4','Flex','19000','Sao Paulo','São Paulo ','',NULL),(3,'GAD-1819','Uno CS/Top/Sport ','Fiat','53334781729','23111551134133333','2005','2006','1.4','Branco','2','Gasolina','13445','Ribeirao Preto','São Paulo ','',NULL),(4,'EHI-5164','Honda City Sedan 16v Auto','Honda','07659252429','19019091309103901','2011','2012','1.0','Prata','5','Flex','15220','Sao Carlos','São Paulo ','',NULL),(5,'BKF-6493','Honda Civic Hatch Lsi','Honda','84907269215','44242424242424242','2012','2013','1.8','Prata','4','Etanol','33120','Barrinha','São Paulo ','',NULL),(6,'DFQ-1636','MONTANA ARENA 1.4 ECONOFLEX  8V','Chevrolet','63850404990','90392039203902930','2010','2010','1.4','Laranja','2','Gasolina','12000','São Calors','São Paulo ','',NULL),(7,'NDG-8177','A4 2.4 30V Tip./Multitronic','Audi','15426624856','12313151515151555','2012','2013','2.4','Azul','4','Flex','29090','Ribeirao Preto','São Paulo ','',NULL);
/*!40000 ALTER TABLE `carro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `checkin`
--

DROP TABLE IF EXISTS `checkin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `checkin` (
  `ckn_id` int(11) NOT NULL AUTO_INCREMENT,
  `ckn_parabrisa_diant` tinyint(1) NOT NULL,
  `ckn_parabrisa_tras` tinyint(1) NOT NULL,
  `ckn_vidro_dianteiro` tinyint(1) NOT NULL,
  `ckn_vidro_traseiro` tinyint(1) NOT NULL,
  `ckn_vidro_diant_esq` tinyint(1) NOT NULL,
  `ckn_vidro_diant_dir` tinyint(1) NOT NULL,
  `ckn_vidro_tras_esq` tinyint(1) NOT NULL,
  `ckn_vidro_tras_dir` tinyint(1) NOT NULL,
  `ckn_port_diant_esq` tinyint(1) NOT NULL,
  `ckn_port_diant_dir` tinyint(1) NOT NULL,
  `ckn_port_tras_esq` tinyint(1) NOT NULL,
  `ckn_port_tras_dir` tinyint(1) NOT NULL,
  `ckn_parachoque_diant` tinyint(1) NOT NULL,
  `ckn_parachoque_tras` tinyint(1) NOT NULL,
  `ckn_roda_diant_esq` tinyint(1) NOT NULL,
  `ckn_roda_diant_dir` tinyint(1) NOT NULL,
  `ckn_roda_tras_esq` tinyint(1) NOT NULL,
  `ckn_roda_tras_dir` tinyint(1) NOT NULL,
  `ckn_pneu_diant_esq` tinyint(1) NOT NULL,
  `ckn_pneu_diant_dir` tinyint(1) NOT NULL,
  `ckn_pneu_tras_esq` tinyint(1) NOT NULL,
  `ckn_pneu_tras_dir` tinyint(1) NOT NULL,
  `ckn_status` varchar(40) NOT NULL,
  `car_id` int(11) NOT NULL,
  PRIMARY KEY (`ckn_id`),
  KEY `car_id` (`car_id`),
  CONSTRAINT `checkin_ibfk_1` FOREIGN KEY (`car_id`) REFERENCES `carro` (`car_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `checkin`
--

LOCK TABLES `checkin` WRITE;
/*!40000 ALTER TABLE `checkin` DISABLE KEYS */;
INSERT INTO `checkin` VALUES (1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,'Disponivel',1),(2,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,'Indisponivel',2),(3,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,'Disponivel',3),(4,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1,1,1,'Disponivel',4),(5,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,'Indisponivel',6);
/*!40000 ALTER TABLE `checkin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `funcionario`
--

DROP TABLE IF EXISTS `funcionario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `funcionario` (
  `fun_id` int(11) NOT NULL AUTO_INCREMENT,
  `fun_nome` varchar(200) NOT NULL,
  `fun_cpf` varchar(20) NOT NULL,
  `fun_login` varchar(20) NOT NULL,
  `fun_senha` varchar(20) NOT NULL,
  `fun_conf_senha` varchar(20) NOT NULL,
  `fun_dta_cadastro` datetime NOT NULL,
  `fun_email` varchar(45) NOT NULL,
  `fun_telefone` varchar(45) NOT NULL,
  `fun_celular` varchar(45) NOT NULL,
  `fun_status` varchar(20) NOT NULL,
  PRIMARY KEY (`fun_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `funcionario`
--

LOCK TABLES `funcionario` WRITE;
/*!40000 ALTER TABLE `funcionario` DISABLE KEYS */;
INSERT INTO `funcionario` VALUES (1,'rogerio jesus de oliveira','317-811-296-06','12345','12345','12345','2016-11-10 00:00:00','rogerio_animes@hotmail.com','(16)2323-1313','(16)13131-3131','Ativo'),(2,'mario gomes','522-350-188-82','12345','22222','22222','2016-11-13 00:00:00','marinho123@terra.com.br','(16)3639-6822','(19)99997-3870','Ativo'),(3,'Fernando Martins','491-564-849-41','11111','11111','11111','2016-11-27 00:00:00','fernandomartins@gmail.com','(16)2504-4994','(16)98591-5155','Ativo');
/*!40000 ALTER TABLE `funcionario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `locacao`
--

DROP TABLE IF EXISTS `locacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `locacao` (
  `loc_id` int(11) NOT NULL AUTO_INCREMENT,
  `loc_dta_loc` datetime NOT NULL,
  `loc_dta_dev` datetime NOT NULL,
  `loc_tipo_locacao` varchar(45) NOT NULL,
  `loc_form_pagamento` varchar(45) NOT NULL,
  `loc_valor_locacao` varchar(45) NOT NULL,
  `loc_status` varchar(45) NOT NULL,
  `ckn_id` int(11) NOT NULL,
  `pj_id` int(11) DEFAULT NULL,
  `pf_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`loc_id`),
  KEY `ckn_id` (`ckn_id`),
  KEY `pj_id` (`pj_id`),
  KEY `pf_id` (`pf_id`),
  CONSTRAINT `locacao_ibfk_1` FOREIGN KEY (`ckn_id`) REFERENCES `checkin` (`ckn_id`),
  CONSTRAINT `locacao_ibfk_2` FOREIGN KEY (`pj_id`) REFERENCES `pessoajuridica` (`pj_id`),
  CONSTRAINT `locacao_ibfk_3` FOREIGN KEY (`pf_id`) REFERENCES `pessoafisica` (`pf_id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `locacao`
--

LOCK TABLES `locacao` WRITE;
/*!40000 ALTER TABLE `locacao` DISABLE KEYS */;
INSERT INTO `locacao` VALUES (1,'2016-11-20 00:00:00','2016-11-25 00:00:00','KM Determinada','Dinheiro/A vista','R$ 120,00','Devolvido',1,NULL,14),(2,'2016-11-20 00:00:00','2016-11-22 00:00:00','KM Determinada','Cartão de Crédito','R$ 30,00','Devolvido',2,NULL,14),(3,'2016-11-20 00:00:00','2016-11-26 00:00:00','KM Livre','Cartão de Crédito','R$ 170,00','Devolvido',3,NULL,13),(4,'2016-11-20 00:00:00','2016-11-28 00:00:00','KM Livre','Cartão de Crédito','R$ 230,00','Devolvido',4,NULL,4),(5,'2016-11-25 00:00:00','2016-11-29 00:00:00','KM Determinada','Cartão de Crédito','R$ 90,00','Devolvido',3,3,NULL),(6,'2016-11-25 00:00:00','2016-11-29 00:00:00','KM Livre','Cartão de Crédito','R$ 110,00','Devolvido',1,3,NULL),(7,'2016-11-26 00:00:00','2016-11-30 00:00:00','KM Determinada','Cartão de Crédito','R$ 90,00','Devolvido',5,10,NULL),(8,'2016-11-26 00:00:00','2016-11-30 00:00:00','KM Livre','Cartão de Crédito','R$ 110,00','Devolvido',5,NULL,1),(9,'2016-11-26 00:00:00','2016-11-28 00:00:00','KM Livre','Cartão de Crédito','R$ 50,00','Devolvido',1,10,NULL),(10,'2016-11-26 00:00:00','2016-11-29 00:00:00','KM Determinada','Cartão de Crédito','R$ 60,00','Devolvido',1,NULL,1),(11,'2016-11-26 00:00:00','2016-11-29 00:00:00','KM Livre','Cartão de Crédito','R$ 80,00','Devolvido',1,NULL,1),(12,'2016-11-27 00:00:00','2016-11-30 00:00:00','KM Livre','Cartão de Crédito','R$ 80,00','Devolvido',1,NULL,5),(13,'2016-11-27 00:00:00','2016-11-29 00:00:00','KM Livre','Cartão de Débito','R$ 50,00','Alugado',5,NULL,9),(14,'2016-11-27 00:00:00','2016-12-02 00:00:00','KM Determinada','Cartão de Crédito','R$ 120,00','Devolvido',4,1,NULL);
/*!40000 ALTER TABLE `locacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pessoafisica`
--

DROP TABLE IF EXISTS `pessoafisica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pessoafisica` (
  `pf_id` int(11) NOT NULL AUTO_INCREMENT,
  `pf_nome` varchar(45) NOT NULL,
  `pf_cpf` varchar(20) NOT NULL,
  `pf_rne` varchar(20) DEFAULT NULL,
  `pf_cnh` varchar(20) NOT NULL,
  `pf_dta_nasc` varchar(20) NOT NULL,
  `pf_mail` varchar(45) DEFAULT NULL,
  `pf_telefone` varchar(20) NOT NULL,
  `pf_celular` varchar(20) NOT NULL,
  `pf_sexo` varchar(20) NOT NULL,
  `pf_est_civil` varchar(20) NOT NULL,
  `pf_endereco` varchar(45) NOT NULL,
  `pf_num_casa` varchar(20) NOT NULL,
  `pf_complemento` varchar(45) DEFAULT NULL,
  `pf_cep` varchar(10) NOT NULL,
  `pf_cidade` varchar(45) NOT NULL,
  `pf_bairro` varchar(45) NOT NULL,
  `pf_uf` varchar(20) NOT NULL,
  `pf_obs` varchar(100) DEFAULT NULL,
  `pf_idf_ativo` tinyint(1) NOT NULL,
  PRIMARY KEY (`pf_id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pessoafisica`
--

LOCK TABLES `pessoafisica` WRITE;
/*!40000 ALTER TABLE `pessoafisica` DISABLE KEYS */;
INSERT INTO `pessoafisica` VALUES (1,'Flavio de Sousa','133-553-123-12','134134134134','55555555555','10/10/1990','flavia@gmail.com','(16)3397-5552','(11)99932-7717','Feminino','Solteiro(a)','Rua dos italianos','2','apartamento','99999-999','Ribeirao Preto','lapa','Distrito Federal','falta xerox dos documentos',0),(2,'Mario brozz ','233-333-333-33','456456456','23232323232','03/03/1970','mariobroz@uol.com.br','(16)3388-8292','(11)99908-2866','Masculino','Divorciado(a)','avenida paulista','80','casa','33232-323','campinas','morumbi','Tocantins','nada consta',0),(3,'Maria da Cruz','121-212-121-21','145145145','99999999999','11/06/1987','maria@hotmail.com','(16)3396-6222','(11)99992-3002','Feminino','Viuvo(a)','rua treze','99','casa','55551-555','ribeirao preto','lagoinha','São Paulo ','falta pagar taxa',0),(4,'Suellen Martinez Borgato','180-729-496-08','','33345455552','01/05/1969','suellenborgato@uol.com.br','(11)3301-3404','(11)99922-3401','Feminino','Viuvo(a)','Rua Cipó','10','casa','07144-692','Guarulhos','Recreio Sao Jose','São Paulo ','',0),(5,'Fernando Gabriel de Almeida','290-352-332-04','','12312312312','19/03/1999','fernando.g.a@gmail.com','(11)3301-3442','(11)89818-1332','Masculino','Casado(a)','Rua principal','11','casa','62602-974','Aguai','Centro','Ceará','',0),(6,'Antonio Martinez Gomes','483-039-646-66','','90901123113','11/06/1973','gomesmartins@gmail.com','(11)3872-7271','(11)95552-1331','Masculino','Divorciado(a)','Rua jose ariza','33','casa','08255-015','Sao paulo','conjunto residencial jose bonifacio','São Paulo ','',0),(7,'Gabriela Fernandes Edman','079-766-124-76','','12312312312','17/09/1966','gabyedman12@hotmail.com','(14)3292-2811','(14)97277-1178','Feminino','Casado(a)','Rua Laurindo Abelardo de Brito','122','casa','05518-090','Sao Paulo','Jardim Trussardi','São Paulo ','falta copia dos documentos ',0),(8,'Marcos Leonard','171-677-527-20','','45611200301','15/03/1988','marquinhosleo@bol.com.br','(14)3212-0977','(14)99818-8221','Masculino','Solteiro(a)','Rua Jose Mangini','100','Casa','13575-385','Sao Carlos','Jardim Botafogo','São Paulo ','',0),(9,'Catia da Silva de Oliveira','200-133-542-30','','34442424244','14/11/1977','catinhasilva@gmail.com','(16)3363-9992','(16)89922-7188','Feminino','Casado(a)','Rua Delloiagono','199','Casa','14057-200','Ribeirao Preto','Parque das Andorinhas','São Paulo ','',0),(10,'Antonia Cardoso Batista dos Reis','065-251-371-95','3ui1239d11','33332323233','11/04/1977','antoniacardoso@terra.com.br','(16)2309-2092','(16)99231-3331','Feminino','Divorciado(a)','Rua Hercília Dártora Szcentes','899','','07743-345','Caieiras','Laranjeiras','SP','Copia do comprovante de endereco',0),(11,'Mariana da Conceicao silva','593-301-452-6','','89898989898','10/10/1988','marisilva@terra.com.br','(18)3332-2131','(18)99933-2299','Feminino','Solteiro(a)','Rua Joao silva diniz','200','casa','32046-020','Contagem','Granja Vista Alegre','Minas Gerais','',0),(12,'Rogerio Marianho Marinho','068-958-934-40','','12313131231','31/03/1980','rogeriomarin@gmail.com','(16)3363-9685','(16)93344-5577','Masculino','Casado(a)','Rua Goncalo Barros','375','Ap 4','05881-130','Sao Paulo','Jardim Soraia','São Paulo ','',0),(13,'Ricardo Mariano','497-864-680-40','','13131313131','10/10/1966','ricardomariano@terra.com.br','(16)3363-6222','(16)98822-8118','Masculino','Casado(a)','Rua Padre Nobrega','11','casa','89205-550','Joinville','Boa Vista','Santa Catarina','',0),(14,'Antonio de Camargo','187-356-400-73','','13132131541','10/10/1966','camarginho.antoni@gmail.com','(14)2739-7467','(14)9985-66124','Masculino','Solteiro(a)','Avenida Joaquim Ferreira Souto','955','Casa','17120-970','Agudos','Centro','São Paulo ','',0),(15,'Juan Alexandre Rocha','108-593-064-53','','31313134444','10/10/1988','juan.alexandre.rocha@asconnet.com.br','(16)3954-4416','(16)9978-94425','Masculino','Casado(a)','Rua Vinte e Três','994','','38181-787','Araxá','Jardim Europa','MG','falta copia da certidao de nascimento',0);
/*!40000 ALTER TABLE `pessoafisica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pessoajuridica`
--

DROP TABLE IF EXISTS `pessoajuridica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pessoajuridica` (
  `pj_id` int(11) NOT NULL AUTO_INCREMENT,
  `pj_raz_soc` varchar(45) NOT NULL,
  `pj_cnpj` varchar(20) NOT NULL,
  `pj_nom_fan` varchar(45) NOT NULL,
  `pj_insc_est` varchar(20) DEFAULT NULL,
  `pj_insc_mun` varchar(20) DEFAULT NULL,
  `pj_mail` varchar(45) DEFAULT NULL,
  `pj_telefone` varchar(20) NOT NULL,
  `pj_celular` varchar(20) NOT NULL,
  `pj_endereco` varchar(45) NOT NULL,
  `pj_num_casa` varchar(20) NOT NULL,
  `pj_complemento` varchar(45) DEFAULT NULL,
  `pj_cep` varchar(20) NOT NULL,
  `pj_cidade` varchar(45) NOT NULL,
  `pj_bairro` varchar(45) NOT NULL,
  `pj_uf` varchar(20) NOT NULL,
  `pj_obs` varchar(100) DEFAULT NULL,
  `pj_idf_ativo` tinyint(1) NOT NULL,
  PRIMARY KEY (`pj_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pessoajuridica`
--

LOCK TABLES `pessoajuridica` WRITE;
/*!40000 ALTER TABLE `pessoajuridica` DISABLE KEYS */;
INSERT INTO `pessoajuridica` VALUES (1,'Rick Roned Pizzaria ME','55,621,503/0001-76','Pizzaria Fest Food','686,888,793,954','15114156','pizzaflex@terra.com.br','(14)2801-5886','(14)98427-6436','Rua Apuco Tavares de Souza','750','Escritorio','19905-040','Ourinhos','Vila Sao José','Sao Paulo','Deve copia da CNH',0),(2,'Otavio e Henry Eletronica ME','24,387,071/0001-57','Tec Tudo Informatica','067,064,349,098','33232323','financeiro@otaviohenry.com.br','(17)2862-7600','(17)99343-2249','Rua Projetada','111','Escritorio','15081-584','Sao José do Rio Preto','Setsul','São Paulo ','',0),(3,'Kevin e Marcela Grafica ME','72.112.384/0001-45','Grafica Kevin','535424344263','90102901','seguranca@kevinmarcela.com.br','(11)3647-2731','(11)98145-1799','Rua Claudio Domingues de Moraes','702','Casa','06786-180','Taboao da Serra','Jardim Sao judas Tadeu','São Paulo ','',0),(4,'Sabrina e Bruna Locacoes de Automoveis Ltda','30.521.059/0001-96','Sabrina Locadora  de Veiculos','170069849920','10331661','producao@sabrinabruna.com.br','(11)2361-2207','(11)99913-1242','Rua Romario Martins','987','Casa','03254-170','Sao Paulo','Vila Sao Nicolau','São Paulo ','',0),(5,'Hugo e Heloisa Entulhos ME','07.133.488/0001-74','Processamento de Entulhos ','849677154540','10331556','representatantes@hugoheloisa.com.br','(14)1351-4692','(14)19938-9524','Rua Orlando Corrêa da Silva','381','','18686-170','Lençóis Paulista','Jardim Primavera','SP','',0),(6,'Ian e Renato Entregas Expressas Ltda','59.242.761/0001-00','Entregas Já','906175246505','19901135','suporte@ianrenato.com.br','(16)3351-7501','(16)99873-4152','Avenida Manoel Monteiro Gutierez','601','Casa','13575-178','Sao Carlos','Jardim Medeiros','São Paulo ','',0),(7,'Nicolas e Issac Mudancas ME','62.542.844/0001-11','Nicolas Mudancas','625428440001','19831983','fale_conosco@nicolasisaac.com.br','(11)3291-4028','(11)99854-6965','Rua Luiz Carlos','365','Casa','06411-120','Barueri','Vila Boa Vista','São Paulo ','',0),(8,'Stella e Caue Marcenaria Me','95.593.836/0001-53','Stella Marcenaria','535146567802','19039090','vendas@stellacaue.com.br','(11)3256-7507','(11)99964-3572','Rua Luara','622','Casa','05665-100','Sao Paulo','Paraisópolis','São Paulo ','',0),(9,'Tomas e Sara Marketing ME','32.456.238/0001-12','TomasMarketing','617397340529','90909091','atendimento@tomassara.com.br','(11)3270-8553','(11)99872-5287','Rua Rodrigues Guiao','169','Casa','05429-030','Sao Paulo','Pinheiros','São Paulo ','',0),(10,'Nathan e Caue Contabil Ltda','03.337.716/0001-77','Nathan Contabilidade','382438035230','88998989','auditoria@nathancaue.com.br','(11)3296-6467','(11)99940-9631','Rua Coroados','287','Casa','09444-160','Ribeirao Pires','Km 4','São Paulo ','',0),(11,'Luuca e Giovanni Advocacia Ltda','62.685.187/0001-61','Luugica Advocacia','712460188895','19301903','orcamento@luccagiovanni.com.br','(12)2670-9358','(12)98210-9628','Rua Dom Joao II','766','Casa','12310-001','Jacarei','Parque dos Principes','São Paulo ',NULL,0),(12,'Julia e Lorenzo Pizzaria Ltda','63.969.077/0001-94','Pizzarua Lorenzo','588727314386','23254155','pos_venda@julialorenzo.com.br','(15)3798-3052','(15)99256-8665','Rua Vidal Gomes da Silveira','909','casa','18087-040','Sorocaba','Ibiti Royal Park I','SP','',0);
/*!40000 ALTER TABLE `pessoajuridica` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-01-11 21:23:59
