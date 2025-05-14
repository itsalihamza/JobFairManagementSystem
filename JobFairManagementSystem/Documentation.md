# CareerConnect - Job Fair Management System Documentation

## Table of Contents
1. [Introduction](#introduction)
2. [System Requirements](#system-requirements)
3. [Installation](#installation)
4. [User Guide](#user-guide)
   - [Students](#students)
   - [Recruiters](#recruiters)
   - [Coordinators](#coordinators)
5. [Admin Guide](#admin-guide)
   - [Dashboard Overview](#dashboard-overview)
   - [Managing Job Fairs](#managing-job-fairs)
   - [Managing Companies](#managing-companies)
   - [Managing Students](#managing-students)
   - [Reporting System](#reporting-system)
6. [Common Issues and Troubleshooting](#common-issues-and-troubleshooting)
7. [Database Structure](#database-structure)

## Introduction

CareerConnect is a comprehensive Job Fair Management System designed to streamline the organization and management of job fairs, connecting students, recruiters, and administrators in a single integrated platform. This system simplifies the process of job fair organization, company registration, student participation, and post-event analysis.

**Key Features:**
- Multi-user platform with role-based access (Students, Recruiters, Coordinators, and Administrators)
- Job fair event creation and management
- Student registration and skill profiling
- Company profile management and job posting
- Interview scheduling and management
- Comprehensive reporting and analytics
- Resource allocation and tracking

## System Requirements

### Minimum Requirements:
- Operating System: Windows 10 or later
- Processor: 1.6 GHz or faster
- Memory: 4 GB RAM
- Storage: 200 MB available hard disk space
- Database: SQL Server 2016 Express or later
- .NET Framework 4.7.2 or later

### Recommended Requirements:
- Processor: 2.0 GHz or faster
- Memory: 8 GB RAM
- Storage: 500 MB available hard disk space
- Database: SQL Server 2019 or later

## Installation

1. **Database Setup:**
   - Install SQL Server if not already installed
   - Execute the CareerConnectDB.sql script to create the database
   - Configure the connection string in the application

2. **Application Installation:**
   - Extract the application files to your preferred location
   - Update the connection string in the configuration file to point to your SQL Server instance
   - Run the JobFairManagementSystem.exe file

3. **First-time Setup:**
   - Log in with the default admin credentials:
     - Username: admin
     - Password: admin123
   - It is recommended to change the default password immediately after first login

## User Guide

### Students

#### Registration and Login
1. Launch the application and click "Register" on the landing page
2. Select "Student" as the user type
3. Fill in required personal information, including:
   - Full name
   - Email address
   - FAST ID
   - Password
   - Contact information
4. Submit the registration form
5. Wait for admin verification (you'll receive confirmation when approved)
6. Once verified, log in with your credentials

#### Profile Management
1. After logging in, click on "My Profile" in the sidebar
2. Update personal information as needed
3. Upload/update your resume
4. Click "Save Changes" to update your profile

#### Skills Management
1. Navigate to "Skills" in the sidebar
2. Add skills from the predefined list
3. Rate your proficiency level for each skill
4. Add certifications if available
5. The system will suggest job matches based on your skills

#### Joining Job Fairs
1. Click on "Job Fairs" in the sidebar
2. Browse upcoming job fairs
3. Click "Register" for the fair you wish to attend
4. Complete the registration form with any specific requirements
5. Receive a confirmation with event details and booth information

#### Applying for Jobs
1. Navigate to "Job Postings" from the sidebar
2. Browse available positions
3. Filter by company, position, or skill requirements
4. Click on a job to view details
5. Click "Apply" to submit your application
6. Track application status in "My Applications"

#### Interview Management
1. Check "My Interviews" to view scheduled interviews
2. Accept or request rescheduling of interviews
3. Add interview notes and preparation materials
4. After interviews, provide feedback if requested

### Recruiters

#### Registration and Login
1. Launch the application and click "Register" on the landing page
2. Select "Recruiter" as the user type
3. Provide company information and personal details
4. Submit the registration form
5. Wait for admin verification
6. Once verified, log in with your credentials

#### Company Profile Management
1. After logging in, navigate to "Company Profile"
2. Add/update company information:
   - Company name
   - Industry/sector
   - Company description
   - Logo
   - Contact information
3. Click "Save Changes" to update

#### Job Posting Management
1. Click on "Job Postings" in the sidebar
2. View existing postings or click "Add New Job"
3. Fill in job details:
   - Job title
   - Description
   - Required skills
   - Salary range
   - Application deadline
4. Click "Post Job" to publish
5. Edit or remove postings as needed

#### Job Fair Participation
1. Navigate to "Job Fairs" in the sidebar
2. Browse upcoming events
3. Click "Register" to participate
4. Select the number of booths required
5. Specify any special requirements
6. Receive booth assignments and event details

#### Application Review
1. Go to "Applications" in the sidebar
2. View all received applications
3. Filter by job posting or status
4. Review student profiles and resumes
5. Change application status:
   - Under Review
   - Shortlisted
   - Interview Scheduled
   - Offered
   - Accepted
   - Rejected

#### Interview Scheduling
1. From the applications list, select shortlisted candidates
2. Click "Schedule Interview"
3. Select available date and time slots
4. Add interview details and requirements
5. Send interview invitation to students
6. Track interview schedules in "Interviews" tab

### Coordinators

#### Login
1. Use coordinator credentials provided by the administrator
2. Access the Coordinator Dashboard

#### Fair Management
1. View assigned job fairs in the dashboard
2. Monitor registration status for students and companies
3. Track booth assignments and availability
4. Manage fair resources

#### Booth Management
1. Navigate to "Booth Management"
2. View booth assignments
3. Make adjustments as needed
4. Track booth check-ins

#### Student and Company Support
1. Respond to queries from the "Support Requests" tab
2. Assist with check-in processes
3. Help resolve issues during the fair
4. Record attendance and participation

#### Reports Generation
1. Go to "Reports" tab
2. Generate real-time participation reports
3. Monitor booth traffic
4. Create post-event summaries

## Admin Guide

### Dashboard Overview

The Admin Dashboard provides a comprehensive view of the entire Job Fair Management System with the following main tabs:
- Job Fairs
- Companies
- Students
- Reports

Each tab contains relevant information and functionality for system administration.

#### Logging In
1. Launch the application
2. Enter admin credentials
3. Access the Admin Dashboard

### Managing Job Fairs

#### Creating a New Job Fair
1. In the Admin Dashboard, select the "Job Fairs" tab
2. Click "Create New Fair" button
3. Fill in the event details:
   - Event title
   - Date
   - Start and end time
   - Venue
   - Description
4. Click "Create Job Fair" to save

#### Managing Existing Job Fairs
1. In the Job Fairs tab, select a fair from the list
2. Click "Manage Fair" to open the management interface
3. Use the tabs to manage different aspects:
   - Fair Details: Edit event information
   - Coordinators: Assign staff to the event
   - Statistics: View registration and participation data

#### Booth Allocation
1. In the fair management interface, go to "Booth Management"
2. View available booths and assignments
3. Manually assign or adjust booth allocations
4. Generate and print booth layout maps

### Managing Companies

#### Approving Company Registrations
1. Go to the "Companies" tab in the Admin Dashboard
2. Review pending company registrations
3. Check company details and verification documents
4. Click "Approve Company" to grant access to the system

#### Monitoring Company Activity
1. Use the companies list to view all registered companies
2. Check individual company profiles
3. View job postings and application statistics
4. Track fair participation history

### Managing Students

#### Verifying Student Accounts
1. Navigate to the "Students" tab
2. Review pending student verifications
3. Verify student identity against FAST ID records
4. Click "Verify Student" to approve the account

#### Student Monitoring
1. Use the student list to view all registered students
2. Check individual profiles and resumes
3. View application and interview statistics
4. Track job fair participation

### Reporting System

The Admin Dashboard includes a powerful reporting system that provides insights into various aspects of the job fair ecosystem. The following reports are available:

#### Student-Focused Reports
1. **Department-wise Registration**
   - Shows student registration counts by department
   - Displays percentage distribution
   - Provides total registration figures

2. **GPA Distribution**
   - Displays student GPA ranges (3.5-4.0, 3.0-3.49, etc.)
   - Shows count and percentage for each range
   - Calculates average GPA across all students

3. **Top Skills**
   - Lists most common skills among registered students
   - Shows student count for each skill
   - Displays popularity percentage

#### Recruiter Activity Reports
1. **Interviews by Company**
   - Tracks interviews conducted per company
   - Shows percentage of total interviews
   - Identifies most active recruiters

2. **Offer Acceptance Ratios**
   - Displays application to offer conversion rates
   - Shows offer acceptance percentages
   - Compares companies by offer effectiveness

3. **Recruiter Ratings**
   - Shows average ratings for recruiters
   - Displays review counts
   - Ranks recruiters by performance

#### Placement Statistics Reports
1. **Overall Placement Statistics**
   - Shows total registered students
   - Tracks fair participation rates
   - Calculates overall placement percentage

2. **Placement Rates by Department**
   - Breaks down placement success by degree program
   - Compares departments by placement effectiveness
   - Shows placement trends

3. **Average Salary by Program**
   - Displays salary ranges by degree program
   - Shows most common salary ranges
   - Identifies highest paying degree programs

#### Event Performance Reports
1. **Booth Traffic Analysis**
   - Tracks visitor counts by company booth
   - Shows unique student visits
   - Calculates average time spent at booths

2. **Peak Participation Hours**
   - Identifies busiest hours during fairs
   - Shows check-in distribution throughout the day
   - Helps optimize event scheduling

3. **Resource Usage Metrics**
   - Tracks booth space utilization
   - Monitors coordinator time allocation
   - Evaluates time slot efficiency

#### Generating Reports
1. Go to the "Reports" tab in the Admin Dashboard
2. Select a report type from the dropdown menu
3. Click "Show Report" to view the data
4. Use "Export to CSV" to download the report for external use

## Common Issues and Troubleshooting

### Login Issues
- **Problem**: Unable to log in despite correct credentials
- **Solution**: 
  - Verify that your account has been approved by an administrator
  - Check for caps lock and input errors
  - Try resetting your password
  - Contact system administrator if problem persists

### Database Connection Issues
- **Problem**: Error message about database connection
- **Solution**:
  - Verify SQL Server is running
  - Check connection string in configuration
  - Ensure network connectivity to database server
  - Contact IT support for database service status

### Report Generation Failures
- **Problem**: Reports fail to generate or display incomplete data
- **Solution**:
  - Check for sufficient data in the system
  - Verify SQL queries are not timing out
  - Try generating smaller reports first
  - Contact administrator for database optimization

### Performance Issues
- **Problem**: System running slowly
- **Solution**:
  - Close unnecessary applications
  - Verify system meets minimum requirements
  - Check network connectivity
  - Consider upgrading hardware if consistently slow

## Database Structure

The CareerConnect system uses a relational database with the following main tables:

### Core Tables
- **Users**: Stores authentication and basic user information
- **Students**: Contains student-specific information
- **Recruiters**: Stores recruiter-specific information
- **Coordinators**: Contains coordinator-specific information
- **Companies**: Stores company profiles and information

### Event-Related Tables
- **JobFairEvents**: Stores job fair event details
- **BoothAssignments**: Maps companies to booth numbers
- **BoothVisits**: Tracks student visits to booths
- **BoothCoordinators**: Assigns coordinators to specific areas

### Job-Related Tables
- **JobPostings**: Contains all job postings
- **Skills**: Master list of available skills
- **StudentSkills**: Maps students to their skills
- **JobSkills**: Maps required skills to job postings
- **Applications**: Tracks student applications to jobs
- **Interviews**: Stores scheduled interviews
- **Reviews**: Contains feedback and ratings

---


