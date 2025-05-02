# CareerConnect - Job Fair Management System

![CareerConnect Logo](logo_placeholder.png)

## Project Overview

CareerConnect is a comprehensive job fair management system designed to streamline the process of organizing, managing, and participating in university job fairs. This Windows Forms application connects students, recruiters, administrators (TPOs), and coordinators through a unified platform to facilitate career opportunities and networking.

## Features

### For Students
- **Job Fair Discovery**: Browse and view details about upcoming job fairs
- **Registration**: Register for job fairs and track registration status
- **Job Application**: Apply to positions posted by recruiters
- **Profile Management**: Create and maintain a detailed profile with educational background, skills, and certifications
- **Interview Scheduling**: View and manage interview schedules

### For Recruiters
- **Booth Registration**: Register for job fairs and request booth space
- **Job Posting**: Create and manage job postings for various positions
- **Applicant Management**: Review applications and manage application statuses
- **Interview Scheduling**: Schedule and manage interviews with applicants

### For Administrators (TPOs)
- **Job Fair Creation**: Create and configure new job fairs
- **Approval Management**: Approve company and student registrations
- **System Oversight**: Monitor and manage the overall system

### For Coordinators
- **Booth Assignment**: Assign booths to registered companies
- **Communication**: Send reminders and notifications to participants
- **Attendance Management**: Generate and manage attendance lists

## Screenshots

### Landing Page
The landing page features a dynamic carousel highlighting key features of CareerConnect, along with quick access buttons for login and registration.

### Login Screen
A modern login interface with role-based authentication supporting Students, Recruiters, TPOs, and Coordinators.

### Registration Form
A comprehensive registration form with validation and guided steps for new users.

### Student Dashboard
Provides students with access to job fairs, job listings, applications, and interviews.

### Recruiter Dashboard
Equips recruiters with tools to manage applications, schedule interviews, post jobs, and register for fairs.

### Administrator Dashboard
Gives administrators oversight of job fairs, company registrations, and student verifications.

### Coordinator Dashboard
Allows coordinators to manage logistical aspects of job fairs including booth assignments and communications.

## Installation

### Prerequisites
- Windows 10 or later
- .NET Framework 4.8 or later
- Visual Studio 2019 or later (for development)
- SQL Server (if database functionality is implemented)

### Setup Instructions
1. **Clone the repository**
   ```
   git clone https://github.com/itsalihamza/JobFairManagementSystem.git
   ```

2. **Open the solution**
   - Launch Visual Studio
   - Open the `JobFairManagementSystem.sln` file

3. **Restore NuGet packages**
   - Right-click on the solution in Solution Explorer
   - Select "Restore NuGet Packages"

4. **Build the solution**
   - Press Ctrl+Shift+B or select Build > Build Solution

5. **Run the application**
   - Press F5 or select Debug > Start Debugging

## Usage Guidelines

### First-Time Use
1. Launch the application
2. From the landing page, click "Register" to create a new account
3. Fill in the registration form and select your role
4. Follow the guided steps to complete your profile setup
5. Log in with your newly created credentials

### For Students
1. Browse available job fairs on the dashboard
2. Register for job fairs of interest
3. View job postings and apply to positions
4. Track application status and manage interviews

### For Recruiters
1. Register for upcoming job fairs
2. Create job postings for open positions
3. Review and manage applicant profiles
4. Schedule interviews with promising candidates

### For Administrators
1. Create and configure job fairs
2. Approve company and student registrations
3. Monitor system usage and generate reports

### For Coordinators
1. Assign booth spaces to registered companies
2. Send communications to participants
3. Generate attendance lists and other operational materials

## Architecture

CareerConnect uses a layered architecture:

- **Presentation Layer**: Windows Forms UI components
- **Business Logic Layer**: Classes handling core functionality
- **Data Access Layer**: Database interaction (placeholder for future implementation)

## Technology Stack

- **Framework**: .NET Framework
- **UI**: Windows Forms
- **Graphics**: System.Drawing for custom graphical elements
- **Future Enhancements**: SQL Server database integration, email notifications

## Project Roadmap

### Current Version
- UI implementation for all user roles
- Simulated data for demonstration purposes
- Complete user journey workflows

### Planned Enhancements
- Database integration for persistent data storage
- Email notifications system
- Report generation functionality
- Mobile companion application
- Integration with university systems
- Enhanced data visualization and analytics

## Development Notes

### Coding Conventions
- Follow Microsoft's .NET Framework Design Guidelines
- Use Pascal Case for class names and method names
- Use Camel Case for local variables and parameters
- Include XML documentation comments for public members

### Build Process
1. Ensure all code compiles without warnings
2. Run any automated tests
3. Perform manual testing of new features
4. Review code for quality and consistency

## Troubleshooting

### Common Issues
- **Login Failures**: Ensure you've registered and are using the correct credentials
- **Display Issues**: Verify your display scaling settings in Windows
- **Performance Concerns**: Close other applications to free up system resources

### Reporting Bugs
Please report any bugs or issues on the project's issue tracker with the following information:
- Steps to reproduce the issue
- Expected behavior
- Actual behavior
- Screenshots (if applicable)
- System specifications

## Contributing

Contributions to CareerConnect are welcome! Please follow these steps:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Contact

Project Maintainer: Your Name - email@example.com

Project Link: [https://github.com/itsalihamza/JobFairManagementSystem](https://github.com/itsalihamza/JobFairManagementSystem) 