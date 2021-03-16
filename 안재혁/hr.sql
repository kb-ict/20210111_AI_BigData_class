--select * from countries ct, regions rg
--where ct.region_id = re.region_id;
--select * from regions;

select * from countries ct, regions rg, locations lt
where lt.country_id = ct.country_id and ct.region_id = rg.region_id;