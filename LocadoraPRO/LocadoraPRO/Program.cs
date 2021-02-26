/*
 * Created by SharpDevelop.
 * User: RAPHAEL BRITO E ALISSON ESTAVAM
 * Date: 24/01/2020
 * Time: 10:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.SqlClient;


namespace LocadoraProject
{	
	class Program
	{
		public static void CadastrarCarro()
{
					string strPlaca, strCor, strAno, strModelo;
					double strValordiaria;
					SqlConnection objCon = new SqlConnection("Server=LABINFO08\\SQLEXPRESS;Database=LOCADORA;User Id=sa;Password=1234abcd;");
					objCon.Open();
					Console.WriteLine("=== CADASTRO DE CARRO ===");
					Console.WriteLine("Digite a Placa");
					strPlaca = Console.ReadLine();
					Console.Clear();				
					Console.WriteLine("Digite o Modelo");
					strModelo = Console.ReadLine();
					Console.Clear();
					Console.WriteLine("Digite a Cor");
					strCor = Console.ReadLine();
					Console.Clear();	
					Console.WriteLine("Digite o Ano");
					strAno = Console.ReadLine();
					Console.Clear();
					Console.WriteLine("Digite o Valor da Diaria");
					strValordiaria = Convert.ToDouble(Console.ReadLine());
					Console.Clear();
					
			 		SqlCommand objComando = new SqlCommand();
					objComando.Connection = objCon;
					objComando.CommandText = "insert into CARROS (PLACA, MODELO, COR, ANO, VALORDIARIA) values " + "('" + strPlaca + "','" + strModelo + "','" + strCor + "','" + strAno + "','" + strValordiaria + "')";
					objComando.ExecuteNonQuery();
					Console.WriteLine("------------------------------------------");
					Console.WriteLine("Cadastro de Veiculo Realizado com Sucesso!"); 		
					Console.WriteLine("------------------------------------------");
					objCon.Close();

}

		public static void CadastrarCliente()
{					
					string strCNH,strCPF,strNome,strCategoria;
					SqlConnection objCon = new SqlConnection("Server=LABINFO08\\SQLEXPRESS;Database=LOCADORA;User Id=sa;Password=1234abcd;");
					objCon.Open();
					
					Console.WriteLine("Digite o Nome do Cliente:");
					strNome = Console.ReadLine();
					Console.Clear();
					Console.WriteLine("Digite o CPF do Cliente:");
					strCPF = Console.ReadLine();
					Console.Clear();
					Console.WriteLine("Digite a CNH do Cliente:");
					strCNH = Console.ReadLine();
					Console.Clear();
					Console.WriteLine("Digite a Categoria da Carteira do Cliente:");
					strCategoria = Console.ReadLine();
					Console.Clear();
	
			 		SqlCommand objComando2 = new SqlCommand();
					objComando2.Connection = objCon;
					objComando2.CommandText = "insert into CLIENTES (NOMECLIENTE, CPF, CNH, CATEGORIACNH) values " + "('" + strNome + "','" + strCPF + "','" + strCNH + "','" + strCategoria + "')";
					objComando2.ExecuteNonQuery();
					Console.WriteLine("------------------------------------------");
					Console.WriteLine("Cadastro de Cliente Realizado com Sucesso!"); 		
					Console.WriteLine("------------------------------------------");
					objCon.Close();
}

		public static void CadastrarAluguel()
{					
					string strIDCarro, strIDCliente;
					SqlConnection objCon = new SqlConnection("Server=LABINFO08\\SQLEXPRESS;Database=LOCADORA;User Id=sa;Password=1234abcd;");
					objCon.Open();
					Console.WriteLine("----------------");
					Console.WriteLine("DIGITE O ID DE QUAL CARRO SERÁ ALUGADO.");
					Console.WriteLine("----------------");
					Console.Write("===> ");
					strIDCarro = Console.ReadLine();
					Console.Clear();
					Console.WriteLine("----------------");
					Console.WriteLine("DIGITE O ID DO CLIENTE QUE ESTÁ ALUGANDO");
					Console.WriteLine("----------------");
					Console.Write("===> ");
					strIDCliente = Console.ReadLine();
					Console.Clear();
					
					SqlCommand objComando3 = new SqlCommand();
					objComando3.Connection = objCon;
					objComando3.CommandText = "insert into ALUGUEL (CARRO, CLIENTE) values " + "('" + strIDCarro + "','" + strIDCliente + "')";
					objComando3.ExecuteNonQuery();	
					Console.WriteLine("------------------------------------------");
					Console.WriteLine("Cadastro de Aluguel Realizado com Sucesso!"); 		
					Console.WriteLine("------------------------------------------");
					objCon.Close();
}
		
		public static void AtualizarCarro()
{
			string strPlaca, strCor, strAno, strModelo, strIDCarro;
			double strValordiaria;
			SqlConnection objCon = new SqlConnection("Server=LABINFO08\\SQLEXPRESS;Database=LOCADORA;User Id=sa;Password=1234abcd;");
			objCon.Open();
			Console.WriteLine("=== ATUALIZANDO CADASTRO DE CARRO ===");
			Console.WriteLine("-------------------------------------");
			Console.WriteLine("Digite o ID do Carro que deseja Atualizar: ");
			strIDCarro = Console.ReadLine();
			
			Console.WriteLine("Digite a Nova Placa:");
			strPlaca = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("Digite a Nova Cor:");
			strCor = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("Digite o Novo Ano:");
			strAno = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("Digite o Novo Modelo:");
			strModelo = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("Digite o novo valor da diaria:");
			strValordiaria = Convert.ToDouble(Console.ReadLine());
			Console.Clear();
			
			SqlCommand objComando4 = new SqlCommand();
			objComando4.Connection = objCon;
			objComando4.CommandText = "UPDATE CARROS SET PLACA = '"+ strPlaca + "', MODELO = '"+ strModelo +"', COR = '"+ strCor +"', ANO = '"+ strAno +"', VALORDIARIA = '"+ strValordiaria +"' WHERE IDCARRO = '"+ strIDCarro +"'";
			objComando4.ExecuteNonQuery();
			Console.WriteLine(objComando4.CommandText);
			Console.WriteLine("------------------------------------------");
			Console.WriteLine("===== CARRO ATUALIZADO com Sucesso! ======"); 		
			Console.WriteLine("------------------------------------------");
			objCon.Close();
			
}
		
		public static void AtualizarCliente()
{
					string strCNH,strCPF,strNome,strCategoria,strIDCliente;
					SqlConnection objCon = new SqlConnection("Server=LABINFO08\\SQLEXPRESS;Database=LOCADORA;User Id=sa;Password=1234abcd;");
					objCon.Open();
					Console.WriteLine("=== ATUALIZANDO CADASTRO DE CLIENTE ===");
					Console.WriteLine("---------------------------------------");
					Console.WriteLine("Digite Qual ID do Cliente que deseja Atualizar:");
					strIDCliente = Console.ReadLine();
					Console.Clear();
					Console.WriteLine("Digite o Nome do Cliente:");
					strNome = Console.ReadLine();
					Console.Clear();
					Console.WriteLine("Digite o CPF do Cliente:");
					strCPF = Console.ReadLine();
					Console.Clear();
					Console.WriteLine("Digite a CNH do Cliente:");
					strCNH = Console.ReadLine();
					Console.Clear();
					Console.WriteLine("Digite a Categoria da Carteira do Cliente:");
					strCategoria = Console.ReadLine();
					Console.Clear();
					
			 		SqlCommand objComando5 = new SqlCommand();
					objComando5.Connection = objCon;
					objComando5.CommandText = "UPDATE CLIENTES SET NOMECLIENTE = '"+ strNome + "', CPF = '"+ strCPF +"', CNH = '"+ strCNH +"', CATEGORIACNH = '"+ strCategoria +"' WHERE IDCLIENTE = '"+ strIDCliente +"'";
					objComando5.ExecuteNonQuery();
					Console.WriteLine("------------------------------------------");
					Console.WriteLine("Cadastro de Cliente Atualizado com Sucesso!"); 		
					Console.WriteLine("------------------------------------------");
					objCon.Close();
}
		
		public static void DeletarCarro()
{
	string strIDCarro;
	SqlConnection objCon = new SqlConnection("Server=LABINFO08\\SQLEXPRESS;Database=LOCADORA;User Id=sa;Password=1234abcd;");
	objCon.Open();
	Console.WriteLine("Qual o ID do Carro que Deseja Deletar?");
	strIDCarro = Console.ReadLine();
	SqlCommand objComando6 = new SqlCommand();
	objComando6.Connection = objCon;
	objComando6.CommandText = "DELETE FROM CARROS WHERE IDCARRO ='"+ strIDCarro + "'";
	objComando6.ExecuteNonQuery();
	Console.WriteLine("------------------------------------------");
	Console.WriteLine("Carro deletado com Sucesso!"); 		
	Console.WriteLine("------------------------------------------");
	objCon.Close();

}
		
		public static void DeletarCliente()
{
	string strIDCliente;
	SqlConnection objCon = new SqlConnection("Server=LABINFO08\\SQLEXPRESS;Database=LOCADORA;User Id=sa;Password=1234abcd;");
	objCon.Open();	
	Console.WriteLine("Qual o ID do Cliente que Deseja Deletar?");
	strIDCliente = Console.ReadLine();
	SqlCommand objComando7 = new SqlCommand();
	objComando7.Connection = objCon;
	objComando7.CommandText = "DELETE FROM CLIENTES WHERE IDCLIENTE ='"+ strIDCliente + "'";
	objComando7.ExecuteNonQuery();
	Console.WriteLine("------------------------------------------");
	Console.WriteLine("Cliente deletado com Sucesso!"); 		
	Console.WriteLine("------------------------------------------");
	objCon.Close();

}
		
		public static void DeletarAluguel()
		{
			string strIDAluguel;
			SqlConnection objCon = new SqlConnection("Server=LABINFO08\\SQLEXPRESS;Database=LOCADORA;User Id=sa;Password=1234abcd;");
			objCon.Open();	
			Console.WriteLine("Qual o ID do ALUGUEL que Deseja Deletar?");
			strIDAluguel = Console.ReadLine();
			SqlCommand objComando12 = new SqlCommand();
			objComando12.Connection = objCon;
			objComando12.CommandText = "DELETE FROM CLIENTES WHERE IDCLIENTE ='"+ strIDAluguel + "'";
			objComando12.ExecuteNonQuery();
			Console.WriteLine("------------------------------------------");
			Console.WriteLine("Aluguel deletado com Sucesso!"); 		
			Console.WriteLine("------------------------------------------");
			objCon.Close();
		}
		
		public static void ConsultarCarros()
{
			string strIDCarro;
			SqlConnection objCon = new SqlConnection("Server=LABINFO08\\SQLEXPRESS;Database=LOCADORA;User Id=sa;Password=1234abcd;");
			objCon.Open();
			Console.WriteLine("Qual o ID do Carro que Deseja Consultar?");
			strIDCarro = Console.ReadLine();
			SqlCommand objComando8 = new SqlCommand();
			objComando8.Connection = objCon;
			objComando8.CommandText = "SELECT * FROM CARROS WHERE IDCARRO ='"+ strIDCarro + "'";
			objComando8.ExecuteNonQuery();
			Console.WriteLine("| IDCARRO :-: PLACA :-: MODELO :-: COR :-: ANO :-: VALORDIARIA |");
			SqlDataReader objDataReader = objComando8.ExecuteReader();
				   
			if (objDataReader.HasRows)
			{
			while (objDataReader.Read())
			{ 
			Console.WriteLine(objDataReader[0].ToString() + " " + objDataReader[1].ToString() + " " + objDataReader[2].ToString() + " " + objDataReader[3].ToString() + " " + objDataReader[4].ToString() + " " + objDataReader[5].ToString());
			}
			}
			else
			{
			Console.WriteLine("Não há Registros");
			}
			Console.WriteLine("------------------------------------------");
			objCon.Close();
}
		
		public static void ConsultarClientes()
{
	string strIDCliente;
	SqlConnection objCon = new SqlConnection("Server=LABINFO08\\SQLEXPRESS;Database=LOCADORA;User Id=sa;Password=1234abcd;");
	objCon.Open();	
	Console.WriteLine("Qual o ID do Cliente que Deseja Consultar?");
	strIDCliente = Console.ReadLine();
	SqlCommand objComando10 = new SqlCommand();
	objComando10.Connection = objCon;
	objComando10.CommandText = "SELECT * FROM CLIENTES WHERE IDCLIENTE ='"+ strIDCliente + "'";
	objComando10.ExecuteNonQuery();
	Console.WriteLine("IDCLIENTE --- NOME --- CPF --- CNH --- CATEGORIA DA CNH  ");
	Console.WriteLine("---------------------------------------------------------");
	SqlDataReader objDataReader = objComando10.ExecuteReader();
		   
	if (objDataReader.HasRows)
	{
	while (objDataReader.Read())
	{ 
	Console.WriteLine(objDataReader[0].ToString() + "-" + objDataReader[1].ToString() + "-" + objDataReader[2].ToString() + "-" + objDataReader[3].ToString() + "-" + objDataReader[4].ToString());
	}
	}
	else
	{
	Console.WriteLine("Não há Registros");
	}
	Console.WriteLine("---------------------------------------------------------");

	objCon.Close();
}
		
		public static void ConsultarAlugueis()
		{
		string strIDAluguel;
		SqlConnection objCon = new SqlConnection("Server=LABINFO08\\SQLEXPRESS;Database=LOCADORA;User Id=sa;Password=1234abcd;");
		objCon.Open();	
		Console.WriteLine("Qual o ID do ALUGUEL que Deseja Consultar?");
		strIDAluguel = Console.ReadLine();
		SqlCommand objComando11 = new SqlCommand();
		objComando11.Connection = objCon;
		objComando11.CommandText = "SELECT * FROM ALUGUEL WHERE IDALUGUEL ='"+ strIDAluguel + "'";
		objComando11.ExecuteNonQuery();
		Console.WriteLine("ID DO ALUGUEL --- CARRO --- CLIENTE --- DIA RETIRADA --- PREVISÃO DE ENTREGA");
		Console.WriteLine("---------------------------------------------------------");
		SqlDataReader objDataReader = objComando11.ExecuteReader();
			   
		if (objDataReader.HasRows)
		{
		while (objDataReader.Read())
		{ 
		Console.WriteLine(objDataReader[0].ToString() + "-" + objDataReader[1].ToString() + "-" + objDataReader[2].ToString() + "-" + objDataReader[3].ToString() + "-" + objDataReader[4].ToString());
		}
		}
		else
		{
		Console.WriteLine("Não há Registros");
		}
		Console.WriteLine("---------------------------------------------------------");
	
		objCon.Close();
		}
		
		public static void Menu()
{

			int opcao,Cadastrar,Atualizar,Deletar, Consultar;		    
		   	
			Cadastrar = 0;
			Atualizar = 0;
			Deletar = 0;
			Consultar =0;
			
			Console.WriteLine("Bem vindo a Locadora!");
			Console.WriteLine("---------------------");
			Console.WriteLine("O que deseja fazer?");
			Console.WriteLine("1. Cadastrar \n2. Atualizar \n3. Deletar\n4. Consultar");
			Console.WriteLine("---------------------");
			Console.Write("===> ");
			opcao = Convert.ToInt16(Console.ReadLine());
			Console.Clear();
			if (opcao == 1)
			{
				Console.WriteLine("---------------------");
				Console.WriteLine("1. Cadastrar Carro \n2. Cadastrar Cliente \n3. Cadastrar Aluguel");
				Console.WriteLine("---------------------");
				Console.Write("===> ");
				Cadastrar = Convert.ToInt16(Console.ReadLine());
				Console.Clear();
				switch (Cadastrar)
				{
					case 1:
						CadastrarCarro();
						break;
					case 2:
						CadastrarCliente();
						break;
					case 3:
						CadastrarAluguel();
						break;
					default:
						Console.WriteLine("Escolha outra opção!");
						break;
				}
					
			}
			else if (opcao == 2)
			{
				Console.WriteLine("---------------------");
				Console.WriteLine("1. Atualizar Carro \n2. Atualizar Cliente");
				Console.WriteLine("---------------------");
				Console.Write("===> ");
				Atualizar = Convert.ToInt16(Console.ReadLine());
				Console.Clear();
				switch (Atualizar)
				{
					case 1:
						AtualizarCarro();
						break;
					case 2:
						AtualizarCliente();
						break;
					default:
						Console.WriteLine("Escolha outra opção!");
						break;
				}
			}
			else if (opcao == 3)
			{
				Console.WriteLine("---------------------");
				Console.WriteLine("1. Deletar Carro \n2. Deletar Cliente \n3. Deletar Aluguel");
				Console.WriteLine("---------------------");
				Console.Write("===> ");
				Deletar = Convert.ToInt16(Console.ReadLine());
				Console.Clear();
				switch (Deletar)
				{
					case 1:
						DeletarCarro();
						break;
					case 2:
						DeletarCliente();
						break;
					case 3:
						DeletarAluguel();
						break;
					default:
						Console.WriteLine("Escolha outra opção!");
						break;
				}
			}
			else if (opcao == 4)
			{
				Console.WriteLine("---------------------");
				Console.WriteLine("1. Consultar ID de Carros \n2. Consultar ID de Clientes \n3. Consultar ID de Alugueis");
				Console.WriteLine("---------------------");
				Console.Write("===> ");
				Consultar = Convert.ToInt16(Console.ReadLine());
				Console.Clear();
				
				switch (Consultar)
				{
					case 1:
						ConsultarCarros();
						break;
					case 2:
						ConsultarClientes();
						break;
					case 3:
						ConsultarAlugueis();
						break;
					default:
						Console.WriteLine("Escolha outra opção!");						
						break;
				}
			}
}
		
		public static void Main(string[] args)
		{
			bool loop = true;
			while (loop) 
			{
			Menu();
			Console.WriteLine("1 PARA SAIR - 2 PARA VOLTAR AO MENU INICIAL");
			Console.WriteLine("------------------");
			Console.Write("===> ");
			string sair = Console.ReadLine();
			Console.Clear();
			if(sair == "1"){ loop = false;}
			if(sair == "2") {  loop = true;}
		}	
			Console.ReadKey(true);
		}		
	}
}