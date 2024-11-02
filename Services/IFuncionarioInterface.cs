using WebAPI_Funcionarios.Models;

namespace WebAPI_Funcionarios.Services
{
    public interface IFuncionarioInterface
    {

        //Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionarios();
        //pegar uma lista de funcionariosmodel atraves da serviceresponse
        Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionarios();

        //Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionario(FuncionarioModel novoFuncionario);
        //criar funcionario
        Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionario(FuncionarioModel novoFuncionario);

        //Task<ServiceResponse<FuncionarioModel>> GetFuncionarioById(int id);
        //pegar id do funcionario
        Task<ServiceResponse<FuncionarioModel>> GetFuncionarioByID(int id);

        //Task<ServiceResponse<List<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel editadoFuncionario);
        //editar funcionario
        Task<ServiceResponse<List<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel atualizaFuncionario);

        //Task<ServiceResponse<List<FuncionarioModel>>> DeleteFuncionario(int id);
        //deletar funcionario 
        Task<ServiceResponse<List<FuncionarioModel>>> DeleteFuncionario(int id);

        //Task<ServiceResponse<List<FuncionarioModel>>> InativaFuncionario(int id);
        //inativar funcionario
        Task<ServiceResponse<List<FuncionarioModel>>> InativaFuncionario(int id);












    }
}
