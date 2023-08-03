#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace Pokedex.Models;
public class PokemonParty : BaseEntity
{
    [Key]
    public int PokemonPartyId { get; set; }
    public string[] PartyMembers { get; set; }
}