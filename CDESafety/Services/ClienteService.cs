using AutoMapper;
using CDESafety.Data.Dtos.ClienteDto;
using CDESafety.Data;
using CDESafety.Models;
using FluentResults;

namespace CDESafety.Services
{
    public class ClienteService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public ClienteService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadClienteDto AdicionaCliente(CreateClienteDto clienteDto)
        {
            Cliente cliente = _mapper.Map<Cliente>(clienteDto);
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return _mapper.Map<ReadClienteDto>(cliente);
        }

        public List<ReadClienteDto> RecuperarCliente()
        {
            List<Cliente> clientes = _context.Clientes.ToList();

            if (clientes == null) return null;

            List<ReadClienteDto> readDto = _mapper.Map<List<ReadClienteDto>>(clientes);

            return readDto;
        }


        public ReadClienteDto RecuperarClientePorId(int id)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(cliente => cliente.Id == id);

            if (cliente != null)
            {
                ReadClienteDto clienteDto = _mapper.Map<ReadClienteDto>(cliente);

                return clienteDto;
            }

            return null;
        }

        public Result DeletaCliente(int id)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(cliente => cliente.Id == id);

            if (cliente == null) return Result.Fail("Cliente não encontrado");

            _context.Remove(cliente);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
