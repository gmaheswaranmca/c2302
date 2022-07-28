select * from flight WHERE travel_date='2022-08-01'
UNION ALL
select * from flight where destination_point='BANGALORE' OR source_point='BANGALORE';


select * from flight WHERE travel_date='2022-08-01'
UNION
select * from flight where destination_point='BANGALORE' OR source_point='BANGALORE';

select * from flight WHERE travel_date='2022-08-01'
INTERSECT
select * from flight where destination_point='BANGALORE' OR source_point='BANGALORE';

select * from flight WHERE travel_date='2022-08-01'
EXCEPT
select * from flight where destination_point='BANGALORE' OR source_point='BANGALORE';
