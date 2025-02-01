# Unofficial SDK for Forge of Empires

An unofficial SDK providing API access to Forge of Empires, developed as part of the [foemanager.com](https://foemanager.com) project. While primarily focused on Forge of Empires, the communication protocols are similar to Elvenar, making this SDK potentially suitable for both games. The repository includes model classes for Forge of Empires and Heroes of History.

## Important Notes

- This SDK implements read-only operations to prevent potential misuse and ensure responsible interaction with game servers
  - API calls that perform actions on game servers or push data to servers are deliberately excluded
  - Pull Requests containing such functionality will not be accepted
  - This includes, but is not limited to: building placement, resource collection etc
- Certain critical implementations (e.g., `IGameSecretProvider`, `IFoeSignatureFactory`) are deliberately excluded from this repository. These components handle sensitive operations such as payload signing for server communication. This decision was made to avoid potential concerns from Innogames
- These components are essential for successful communication with game servers and must be implemented separately
- Last verified working: September 2024

## Status

The game's authentication process is periodically updated by Innogames (with changes observed in Fall 2024). Additionally, model classes may change with game updates. While active maintenance from the original author is unlikely, contributions via Pull Requests are welcome.

## Potential Uses

This SDK can be valuable for developers interested in building tools and applications for Forge of Empires or Elvenar. For example:
- City planning tools (like the previously implemented Foe City Planner)
- Game statistics analyzers
- Resource management applications
- Player progress tracking tools

## Previous Applications

This SDK has powered various tools, including the Foe City Planner previously available on foemanager.com.

## Disclaimer

This project is provided "as is" without warranty of any kind. It is not affiliated with or endorsed by Innogames.
