﻿namespace EvolutionaryArchitecture.Fitnet.Contracts.Core;

public interface IBindingContractsRepository
{
    Task<BindingContract?> GetByContractIdAsync(Guid contractId, CancellationToken cancellationToken = default);
    Task AddAsync(BindingContract bindingContract, CancellationToken cancellationToken = default);
    Task CommitAsync(CancellationToken cancellationToken = default);
}
