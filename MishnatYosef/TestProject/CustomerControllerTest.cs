using Microsoft.AspNetCore.Mvc;
using MishnatYosef.Controllers;
using MishnatYosef.Data;
using MishnatYosef.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class CustomerControllerTest
    {
        [Fact]
        public void GetAll_ReturnsListOfCustomers()
        {
            //Arrange

            //Act
            var controller=new CustomerController(new MishnatYosef.Services.CustomerService(new CustomersFakeData()));
            var result = controller.Get();
            //Assert
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void GetById_ReturnsOk()
        {
            //Arrange
            var id = 1;
            //Act
            var controller = new CustomerController(new MishnatYosef.Services.CustomerService(new CustomersFakeData()));
            var result = controller.Get(id);
            //Assert
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void GetById_ReturnsNotFound()
        {
            //Arrange
            int id = 5;
            //Act
            var controller = new CustomerController(new MishnatYosef.Services.CustomerService(new CustomersFakeData()));
            var result = controller.Get(id);
            //Assert
            Assert.IsType<NotFoundResult>(result);
        }
        [Fact]
        public void Post_ReturnsOk()
        {
            //Arrange
            Customer c = new Customer() {Id=4,Identity="327862892" };
            //Act
            var controller = new CustomerController(new MishnatYosef.Services.CustomerService(new CustomersFakeData()));
            var result = controller.Post(c);
            //Assert
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void Post_ReturnsBadRequest()
        {
            //Arrange
            Customer c = new Customer() { Id = 1, Identity = "322892" };
            //Act
            var controller = new CustomerController(new MishnatYosef.Services.CustomerService(new CustomersFakeData()));
            var result = controller.Post(c);
            //Assert
            Assert.IsType<BadRequestResult>(result);
        }
        [Fact]
        public void Put_ReturnsOk()
        {
            //Arrange
            Customer c = new Customer() { Id = 1, Identity = "322849" };
            //Act
            var controller = new CustomerController(new MishnatYosef.Services.CustomerService(new CustomersFakeData()));
            var result = controller.Put(1, c);
            //Assert
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void Delete_ReturnsOk()
        {
            //Arrange
            var id = 1;
            //Act
            var controller = new CustomerController(new MishnatYosef.Services.CustomerService(new CustomersFakeData()));
            var result = controller.Delete(id);
            //Assert
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void Delete_ReturnsNotFound()
        {
            //Arrange
            var id = 8;
            //Act
            var controller = new CustomerController(new MishnatYosef.Services.CustomerService(new CustomersFakeData()));
            var result = controller.Delete(id);
            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

    }
}
