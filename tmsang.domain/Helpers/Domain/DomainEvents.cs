using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace tmsang.domain
{

    //public class MyServices<T>: Handles<T> where T: DomainEvent
    //{
    //    public readonly IEnumerable<Handles<T>> services;

    //    public MyServices()
    //    {
    //    }

    //    public MyServices(IEnumerable<Handles<T>> rules)
    //    {
    //        this.services = rules;
    //    }

    //    public void Handle(T args)
    //    {
    //    }
    //}

    public static class DomainEvents
    {
        [ThreadStatic]
        private static List<Delegate> actions;

        private static IServiceProvider Container;

        public static void Init(IServiceProvider container) {
            Container = container;
        }

        // Register a callback for the given event, used for testing only
        public static void Register<T>(Action<T> callback) where T : DomainEvent {
            if (actions == null) {
                actions = new List<Delegate>();
            }
            actions.Add(callback);
        }

        // Clear callbacks passed to Register on the current thread
        public static void ClearCallbacks() {
            actions = null;
        }

        // Raise the given domain event
        public static void Raise<T>(T args) where T : DomainEvent {
          
            if (Container != null) {
                // var handlers = Container.GetRequiredService<Handles<T>>();
                var handlers = Container.GetServices<Handles<T>>();                 // TODO: ??? khong biet tai sao here -> gay loi (singleton - ma lai di load constructor lai ????)
                foreach (var handler in handlers) {
                    handler.Handle(args);
                }
            }

            if (actions != null) {
                foreach (var action in actions) {
                    if (action is Action<T>) {
                        ((Action<T>)action)(args);          // execute action in list
                    }
                }
            }
        }

    }
}
