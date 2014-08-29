#region License Information
/* HeuristicLab
 * Copyright (C) 2002-2014 Heuristic and Evolutionary Algorithms Laboratory (HEAL)
 *
 * This file is part of HeuristicLab.
 *
 * HeuristicLab is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * HeuristicLab is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with HeuristicLab. If not, see <http://www.gnu.org/licenses/>.
 */
#endregion


namespace HeuristicLab.PluginInfrastructure {
  /// <summary>
  /// Represents a plugin.
  /// Plugin developers have to include exactly one class that implements this interface in one of the
  /// assemblies of the plugin. 
  /// OnLoad() and OnUnLoad() are called by the framework when the plugin is loaded/unloaded.
  /// </summary>
  public interface IPlugin {
    /// <summary>
    /// Gets the name of the plugin.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Called by the framework whenever the plugin is loaded.
    /// Plugins are loaded when a new application is started from the starter.
    /// </summary>
    void OnLoad();

    /// <summary>
    /// Called by the framework whenever the plugin is unloaded.
    /// Plugins are unloaded when an application exits.
    /// </summary>
    void OnUnload();
  }
}