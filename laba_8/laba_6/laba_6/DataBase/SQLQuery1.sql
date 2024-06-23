use master  
go
--D:\University\OOP\laba_8\laba_6\laba_6\DataBase
drop database Configurator
create database Configurator
on primary
( name = N'Configurator_mdf', filename = N'D:\University\OOP\laba_8\laba_6\laba_6\DataBase\Configurator_mdf.mdf', 
   size = 10240Kb, maxsize=UNLIMITED, filegrowth=1024Kb)
   log on
( name = N'Configurator_log', filename = N'D:\University\OOP\laba_8\laba_6\laba_6\DataBase\Configurator_log.ldf', 
   size = 10240KB, maxsize=1Gb, filegrowth=25%)
go
