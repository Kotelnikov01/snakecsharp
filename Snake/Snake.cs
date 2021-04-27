using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Snake : Figure
	{
		Direction direction;
		public List<Char> cap;
		int ind = 0;

		public Snake(Point tail, int length, Direction _direction)
		{
			direction = _direction;
			plist = new List<Point>();
			cap = new List<char>();
			cap.Add('c');
			cap.Add('a');
			cap.Add('p');
			cap.Add('i');
			cap.Add('t');
			cap.Add('a');
			cap.Add('l');
			cap.Add('i');
			cap.Add('s');
			cap.Add('m');
			int ind = 9;

			for (int i = 0; i < length; i++)
			{
				Point p = new Point(tail);
				p.Move(i, direction);
				p.sym = cap[ind];
				ind--;
				plist.Add(p);
			}
		}

		internal void Move()
		{
			
			Point tail = plist.First();
			plist.Remove(tail);
			Point head = GetNextPoint();
			plist.Add(head);
			tail.Clear();
			head.Draw();
		}

		public Point GetNextPoint()
		{
			Point head = plist.Last();
			head.sym = cap.ElementAt(ind);
			Point nextPoint = new Point(head);
			//nextPoint.sym = cap[0];
			nextPoint.Move(1, direction);
			ind++;
			if (ind == 9)
			{ ind = 0; }
			return nextPoint;
			
		}

		public void HandleKey(ConsoleKey key)
		{
			if (key == ConsoleKey.LeftArrow)
				direction = Direction.LEFT;
			else if (key == ConsoleKey.RightArrow)
				direction = Direction.RIGHT;
			else if (key == ConsoleKey.DownArrow)
				direction = Direction.DOWN;
			else if (key == ConsoleKey.UpArrow)
				direction = Direction.UP;
		}

		internal bool Eat(Point food)
		{
			Point head = GetNextPoint();
			if (head.IsHit(food))
			{
				food.sym = head.sym;
				plist.Add(food);
				return true;
			}
			else
				return false;
		}
	}
}