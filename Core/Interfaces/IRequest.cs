﻿using NotificationEngineWorker.Core.Data.Enums;

namespace NotificationEngineWorker.Core.Interfaces;

/// <summary>
/// Request message from producer
/// </summary>
public interface IRequest
{
    /// <summary>
    /// Unique identifier used to discern between clients and servers
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Unique identifier used for the producer
    /// </summary>
    Guid ProducerId { get; set; }

    /// <summary>
    /// Unique identifier of the current machine cycle.
    /// To be used between different Producer if they need to synchronize with other producers
    /// </summary>
    Guid MachineCycleId { get; set; }

    /// <summary>
    /// Message, may be prompt or other instruction or left empty for Types with default instruction
    /// </summary>
    string? Message { get; set; }

    /// <summary>
    /// Type of notification request
    /// </summary>
    ProducerType Type { get; set; }

    /// <summary>
    /// Request message
    /// </summary>
    string Request { get; set; }
}
