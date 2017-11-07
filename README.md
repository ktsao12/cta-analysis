Kevin Tsao
CTA Analysis

Originally Homework #7: N-Tier Architecture
for CS341: Programming Language Concepts with Professor Joe Hummel
Relational databases, N-tier architecture, SQL, C#

The goal of this assignment was to design and create a three-tier architecture program that read in data in the form of a PDF, created a database from that data, and then provided a GUI for users to access the data and perform queries. The presentation tier was written in C#, and the logic tier written in SQL.

The Chicago Transit Authority is the mass public transit system of Chicago, Illinois and some of its surrounding suburbs. The system features eight routes and services, according to its official website, over 750,000 trips daily. The data used for this program was downloaded directly from the official website and provides a snapshot of activity for that time period (Fall 2016). 

The database contains every single stop on every single train route of the CTA and details, amongst other things, how many people passed through that station on a daily basis, the % ridership of that station compared to the whole system, and which lines are available at each station. The user can readily look up all of this information, and the GUI also comes with a few pre-packaged queries that can return such things as the top 10 stations on a Saturday, etc.