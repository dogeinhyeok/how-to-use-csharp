/* 컬렉션 맛보기: Queue */
using System.Collections;

Queue que = new Queue();
que.Enqueue(1);
que.Enqueue(2);
que.Enqueue(3);
que.Enqueue(4);
que.Enqueue(5);

while (que.Count > 0)
	Console.WriteLine(que.Dequeue());