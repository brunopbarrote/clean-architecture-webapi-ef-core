namespace MyWallet.Domain {
    using System;

    internal interface IEntity {
        Guid Id { get; }
    }
}