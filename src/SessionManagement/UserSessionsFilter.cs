// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.


namespace Duende.SessionManagement;

/// <summary>
/// Filter to query user sessions
/// </summary>
public class UserSessionsFilter
{
    /// <summary>
    /// The subject ID
    /// </summary>
    public string? SubjectId { get; init; }

    /// <summary>
    /// The sesion ID
    /// </summary>
    public string? SessionId { get; init; }

    /// <summary>
    /// Validates
    /// </summary>
    public void Validate()
    {
        if (String.IsNullOrWhiteSpace(SubjectId) && String.IsNullOrWhiteSpace(SessionId))
        {
            throw new ArgumentNullException("SubjectId or SessionId is required.");
        }
    }
}
