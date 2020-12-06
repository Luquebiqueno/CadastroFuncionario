Use CadastroFuncionario
Go


If Object_Id('Habilidade') Is Null 
Begin
	Create Table Habilidade 
	(
		 HabilidadeId	Int Identity(1,1) Constraint PK_Habilidade_HabilidadeId Primary Key
		,Descricao		Varchar(50) Not Null
	)
End
Go

If Object_Id('Sexo') Is Null 
Begin
	Create Table Sexo 
	(
		 SexoId		Int Identity(1,1) Constraint PK_Sexo_SexoId Primary Key
		,Descricao	Varchar(30) Not Null
	)
End
Go

If Object_Id('Funcionario') Is Null 
Begin
	Create Table Funcionario 
	(
		 FuncionarioId		Int Identity(1,1) Constraint PK_Funcionario_FuncionarioId Primary Key
		,Nome				Varchar(128)	Not Null
		,Sobrenome			Varchar(128)	Not Null
		,DataNascimento		Date			Not Null
		,Email				Varchar(100)		Null
		,Idade				Int				Not Null
		,Ativo				Bit				Not Null
		,HabilidadeId		Int				Not Null
		,SexoId				Int				Not Null
	)
End
Go
