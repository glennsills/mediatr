using SampleValueFeatures.Features.DataValues.AddValue;
using SampleValueFeatures.Features.DataValues.Get;
using SampleValueFeatures.Features.DataValues.GetValueByKey;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleWeb.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    private readonly IMediator _mediator;

    public ValuesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // GET: api/<ValuesController>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<string>>> Get()
    {
        GetAllValues getAllValuesRequest = new();
        var result = await _mediator.Send(getAllValuesRequest);
        return Ok(result);
    }

    // GET api/<ValuesController>/5
    [HttpGet("{key}")]
    public async Task<ActionResult<string>> Get(string key)
    {
        var getValueByKeyRequest = new GetValueByKey { Key = key };
        var result = await _mediator.Send(getValueByKeyRequest);
        return Ok(result);
    }

    // POST api/<ValuesController>
    [HttpPost]
    public async Task<ActionResult> Post([FromBody] AddValueViewModel addValue)
    {
        var addValueRequest = new AddValue { Key = addValue.Key, Value = addValue.Value };
        var result = await _mediator.Send(addValueRequest);
        return Ok(result);
    }

    // PUT api/<ValuesController>/5
    [HttpPut("{id}")]
    public Task<ActionResult> Put(string key, [FromBody] string value)
    {
        throw new NotImplementedException();
    }

    // DELETE api/<ValuesController>/5
    [HttpDelete("{id}")]
    public Task<ActionResult> Delete(string key)
    {
        throw new NotImplementedException();
    }
}