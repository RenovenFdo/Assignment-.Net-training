	--1
	select a.account_number,c.customer_number,c.firstname,c.lastname,a.account_opening_date
	from customer_master c inner join account_master a
	on c.customer_number=a.customer_number  
	order by a.account_number asc

	--2
	select count(customer_number) as Cust_count from customer_master where customer_city='DELHI'

	--3
	select c.customer_number,c.firstname,a.account_number
	from customer_master c inner join account_master a
	on c.customer_number=a.customer_number
	where day(a.account_opening_date)>15 
	order by c.customer_number,a.account_number 

	--4
	select c.customer_number,c.firstname,a.account_number
	from customer_master c inner join account_master a
	on c.customer_number=a.customer_number
	where a.account_status='TERMINATED'
	order by c.customer_number,a.account_number

	--5
	select t.transaction_type,count(t.transaction_type) asTrans_count
	from transaction_details t inner join account_master a
	on a.account_number=t.account_number
	where a.customer_number like '%001'  
	group by t.transaction_type

	--6
	select count(*) as Count_Customer 
	from customer_master 
	where customer_number not in (select distinct customer_number from account_master )

	--7
	select t.account_number,sum(t.transaction_amount)+a.opening_balance from transaction_details t
	join account_master a on a.account_number=t.account_number
	where transaction_type = 'DEPOSIT'
	group by t.account_number, a.opening_balance