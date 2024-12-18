using MediatR;

namespace Catalog.API.Products.CretaeProduct
{

    public record CreateProductCommand(string Name, List<string> Categories, string Description, string ImageFile, decimal Price)

        : IRequest<CreateProductResult>;

    public record CreateProductResult(Guid Id);

    internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            //Bussiness logic to create a product
            throw new NotImplementedException();
        }
    }
}
