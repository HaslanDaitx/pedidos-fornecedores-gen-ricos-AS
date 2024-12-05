using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class PedidosController : ControllerBase
{
    private readonly IGenericRepository<Pedido> _repository;

    public PedidosController(IGenericRepository<Pedido> repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public ActionResult<List<Pedido>> GetAll()
    {
        var pedidos = _repository.GetAll();
        return Ok(pedidos);
    }

    [HttpGet("{id}")]
    public ActionResult<Pedido> Get(int id)
    {
        var pedido = _repository.GetById(id);
        if (pedido == null)
            return NotFound();

        return Ok(pedido);
    }

    [HttpPost]
    public ActionResult Post(Pedido pedido)
    {
        _repository.Add(pedido);
        return CreatedAtAction(nameof(Get), new { id = pedido.Id }, pedido);
    }

    [HttpPut("{id}")]
    public ActionResult Put(int id, Pedido pedidoAtualizado)
    {
        var pedido = _repository.GetById(id);
        if (pedido == null)
            return NotFound();

        pedido.Data = pedidoAtualizado.Data;
        pedido.ValorTotal = pedidoAtualizado.ValorTotal;
        pedido.Status = pedidoAtualizado.Status;
        pedido.Descricao = pedidoAtualizado.Descricao;

        _repository.Update(pedido);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var pedido = _repository.GetById(id);
        if (pedido == null)
            return NotFound();

        _repository.Delete(pedido);

        return NoContent();
    }
}
