using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Caching;
using System.Xml;
using System.Xml.Serialization;

namespace XmlForAsp.Configuration {

	public class ServerConfigManager {

		private static ServerConfig _Config = GetServerConfig();

		public static ConnectionString GetConnectionString(string database) {
			if (_Config != null) {
				ServerEnvironment env = GetServerEnvironment();
				if (_Config.ConnectionStrings != null) {
					foreach (ConnectionString cs in _Config.ConnectionStrings) {
						if (cs.Database.ToLower() == database.ToLower()) {
							if (env == ServerEnvironment.Development) {
								ConnectionString newCs = new ConnectionString();
								newCs.Database = database;
								newCs.Primary = cs.Development;
								newCs.Secondary = cs.Development;
								newCs.Development = cs.Development;
								return newCs;
							}
							if (env == ServerEnvironment.Production) {
								return cs;					
							}
						}
					}		
				}
			}
			return new ConnectionString();
		}

		public static ConnectionString[] GetConnectionStrings() {
			if (_Config != null) {
				return _Config.ConnectionStrings;
			}
			return null;
		}
		
		public static ServerEnvironment GetServerEnvironment() {
			string hostName = System.Web.HttpContext.Current.Request.Url.Host;
			if (_Config != null) {
				if (_Config.Servers != null) {
					foreach (Server s in _Config.Servers) {
						if (s.Domains != null) {
							foreach (string domain in s.Domains) {
								if (domain.ToLower() == hostName.ToLower()) {
									return s.Environment;
								}
							}
						}
					}
				}
			}
			//Default to development
			return ServerEnvironment.Development;
		}

		public static Server GetServer(string serverName) {
			string hostName = System.Web.HttpContext.Current.Request.Url.Host;
			if (_Config != null) {
				if (_Config.Servers != null) {
					foreach (Server s in _Config.Servers) {
						if (s.Name.ToLower() == serverName.ToLower()) {
							return s;
						}
					}
				}
			}
			return null;
		}

		public static Server GetServer(ServerType type, ServerEnvironment env) {
			if (_Config != null) {
				if (_Config.Servers != null) {
					foreach (Server s in _Config.Servers) {
						if (s.Environment == env && s.Type == type) {
							return s;
						}
					}
				}
			}
			return null;
		}

		public static Server[] GetServers(ServerType type, ServerEnvironment env) {
			ArrayList al = new ArrayList();
			if (_Config != null) {
				if (_Config.Servers != null) {
					foreach (Server s in _Config.Servers) {
						if (s.Environment == env && s.Type == type) {
							al.Add(s);
						}
					}
					return (Server[])al.ToArray(typeof(Server));
				}
			}
			return null;
		}

		public static Server[] GetServers(ServerType type) {
			ArrayList al = new ArrayList();
			if (_Config != null) {
				if (_Config.Servers != null) {
					foreach (Server s in _Config.Servers) {
						if (s.Type == type) {
							al.Add(s);
						}
					}
					return (Server[])al.ToArray(typeof(Server));
				}
			}
			return null;
		}

		public static Server[] GetServers(ServerEnvironment env) {
			ArrayList al = new ArrayList();
			if (_Config != null) {
				if (_Config.Servers != null) {
					foreach (Server s in _Config.Servers) {
						if (s.Environment == env) {
							al.Add(s);
						}
					}
					return (Server[])al.ToArray(typeof(Server));
				}
			}
			return null;
		}

		public static ServerConfig GetServerConfig() {
			HttpContext context = HttpContext.Current;
			XmlTextReader reader = null;					
			try {
				string configPath = ConfigurationManager.AppSettings["ServerConfigPath"];
				if (configPath != null) {
					string fullConfigPath = null;
					if (configPath.IndexOf(":\\") == -1 && configPath.IndexOf(":/") == -1 && 
						!configPath.StartsWith("\\")) { 
						fullConfigPath = HttpContext.Current.Server.MapPath(configPath);
					} else { //Physical path specified
						fullConfigPath = configPath;
					}		

					//Handle cache
					if (context.Cache.Get(fullConfigPath) == null) {
						reader = new XmlTextReader(fullConfigPath);
						XmlSerializer serializer = new XmlSerializer(typeof(ServerConfig));
						ServerConfig sc = (ServerConfig)serializer.Deserialize(reader);
						if (sc != null) {
							CacheDependency dep = new CacheDependency(new string[]{fullConfigPath});
							context.Cache.Insert(fullConfigPath,sc,dep);
						}
						return sc;
					} else {
						return (ServerConfig)context.Cache.Get(fullConfigPath);
					}
				} else {
					return null;
				}
			}
			catch (Exception exp) {
				//Log exception here if desired
				context.Trace.Warn("Error reading server configuration: " + exp.Message);
			}
			finally {
				if (reader != null) reader.Close();
			}
			return null;
		}
	}
}
