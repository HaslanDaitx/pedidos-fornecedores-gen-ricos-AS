using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class FornecedoresController : ControllerBase
{
    private readonly IGenericRepository<Fornecedor> _repository;

    public FornecedoresController(IGenericRepository<Fornecedor> repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public ActionResult<List<Fornecedor>> GetAll()
    {
        var fornecedores = _repository.GetAll();
        return Ok(fornecedores);
    }

    [HttpGet("{id}")]
    public ActionResult<Fornecedor> Get(int id)
    {
        var fornecedor = _repository.GetById(id);
        if (fornecedor == null)
            return NotFound();

        return Ok(fornecedor);
    }

    [HttpPost]
    public ActionResult Post(Fornecedor fornecedor)
    {
        _repository.Add(fornecedor);
        return CreatedAtAction(nameof(Get), new { id = fornecedor.Id }, fornecedor);
    }

    [HttpPut("{id}")]
    public ActionResult Put(int id, Fornecedor fornecedorAtualizado)
    {
        var fornecedor = _repository.GetById(id);
        if (fornecedor == null)
            return NotFound();

        fornecedor.Nome = fornecedorAtualizado.Nome;
        fornecedor.CNPJ = fornecedorAtualizado.CNPJ;
        fornecedor.Telefone = fornecedorAtualizado.Telefone;
        fornecedor.Email = fornecedorAtualizado.Email;
        fornecedor.Endereco = fornecedorAtualizado.Endereco;

        _repository.Update(fornecedor);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var fornecedor = _repository.GetById(id);
        if (fornecedor == null)
            return NotFound();

        _repository.Delete(fornecedor);

        return NoContent();
    }
}
