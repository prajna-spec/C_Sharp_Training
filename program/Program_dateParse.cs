string[] dates = {
    "03/19/2021 07:20:58",
    "03/19/2021",
    "3/2021",
    "3/21",
    "4 AM",
    "2021-03-19T05:20:12.0000000Z",
    "2021-03-19T05:20:12.0000000-05:00",
    "Fri, 19 Mar 2021 05:20:12 GMT"

};

foreach (var date in dates )
{
    var dt=DateTime.Parse(date);
    Console.WriteLine(dt);
}

