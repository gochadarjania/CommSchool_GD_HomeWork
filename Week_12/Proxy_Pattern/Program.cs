using System;

namespace Proxy_Pattern
{
    internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("---Super Actor---\n");
			AbstractActor superActor = new SuperActor();
			superActor.PlayRole();

			Console.WriteLine("\n---Actor----\n");
			Actor actor = new Actor();
			actor.PlayRole();
		}
	}
	abstract class AbstractActor
	{
		public abstract void PlayRole();
	}
	class Actor : AbstractActor
	{
		public override void PlayRole()
		{
			Console.WriteLine("I can play 1 role in a movie.");
		}
	}
	class SuperActor : AbstractActor
	{
		Actor actor;
		public override void PlayRole()
		{
			if (actor == null)
				actor = new Actor();
			actor.PlayRole();
			Console.WriteLine("I can also play other roles.");
		}
	}
}
