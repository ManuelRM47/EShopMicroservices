
namespace Catalog.API.Products.GetProductById;

//public record GetProductByIdRequest(Guid ProductId);

public record GetProductByIdResponse(Product Product);

public class GetProductsByIdEndpoint : ICarterModule
{
	public void AddRoutes(IEndpointRouteBuilder app)
	{
		app.MapGet("/products/{id:guid}", async (Guid id, ISender sender) =>
		{
			var query = new GetProductByIdQuery(id);
			var result = await sender.Send(query);
			var response = result.Adapt<GetProductByIdResponse>();
			return Results.Ok(response);
		})
		.WithName("GetProductById")
		.Produces<GetProductByIdResponse>(StatusCodes.Status200OK)
		.ProducesProblem(StatusCodes.Status400BadRequest)
		.ProducesProblem(StatusCodes.Status404NotFound)
		.WithSummary("Gets a product by ID")
		.WithDescription("Gets a product from the catalog by its ID");
	}
}
