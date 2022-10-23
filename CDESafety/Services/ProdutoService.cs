
using AutoMapper;
using CDESafety.Data.Dtos.ProdutoDto;
using CDESafety.Data;
using CDESafety.Models;
using FluentResults;

namespace CDESafety.Services
{
    public class ProdutoService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public ProdutoService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadProdutoDto AdicionaProduto(CreateProdutoDto produtoDto)
        {
            Produto produto = _mapper.Map<Produto>(produtoDto);
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return _mapper.Map<ReadProdutoDto>(produto);
        }

        public List<ReadProdutoDto> RecuperarProduto()
        {
            List<Produto> produtos = _context.Produtos.ToList();

            if (produtos == null) return null;

            List<ReadProdutoDto> readDto = _mapper.Map<List<ReadProdutoDto>>(produtos);

            return readDto;
        }


        public ReadProdutoDto RecuperarProdutoPorId(int id)
        {
            Produto produto = _context.Produtos.FirstOrDefault(produto => produto.Id == id);

            if (produto != null)
            {
                ReadProdutoDto produtoDto = _mapper.Map<ReadProdutoDto>(produto);

                return produtoDto;
            }

            return null;
        }

        public Result DeletaProduto(int id)
        {
            Produto produto = _context.Produtos.FirstOrDefault(produto => produto.Id == id);

            if (produto == null) return Result.Fail("Produto não encontrado");

            _context.Remove(produto);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
