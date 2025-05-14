using teoria09tarea.Models;
using Application.Interfaces;

namespace Application.UseCases;

public class CreateClientUseCase
{
    private readonly IClientRepository _clientRepository;

    public CreateClientUseCase(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public async Task ExecuteAsync(string name, string email)
    {
        var client = new Client
        {
            Name = name,
            Email = email
        };

        await _clientRepository.AddAsync(client);
    }
}