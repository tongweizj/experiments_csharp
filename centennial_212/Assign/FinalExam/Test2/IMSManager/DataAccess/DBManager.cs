using IMSLibrary.Models;
using IMSManager.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace IMSManager.DataAccess
{
    public  class DBManager
    {
        ImsContext db = new ImsContext();

        public  List<AgentComboBoxModel> GetAgents()
        {
            List<AgentComboBoxModel> agentList = new List<AgentComboBoxModel>();

            // finish the method
            List<Agent> agents = db.Agents.ToList(); // 异步执行查询

            foreach (Agent agent in agents)
            {
                agentList.Add(new AgentComboBoxModel(agent.Id,agent.Fname,agent.Lname));
            }
            return agentList;
        }

        public List<PolicyDetails> GetPolicyDetails(string agentId)
        {
            List<PolicyDetails> insuranceList = new List<PolicyDetails>();
            //List<Agent> agents = db.Agents.ToList();

            insuranceList=  db.InsurancePolicies
               .Join(db.Products,
                   i => i.ProductCode, // 购物篮关联购物者的外键
                   p => p.Code,
                   (i, p) => new PolicyDetails(
                       i.Id,
                       p.Name,
                        i.PolicyDate,
                        i.Premium,
                        i.Insured
                   ))
               .ToList();
            // finish the method

            return insuranceList;
        }

        public List<ProductComboBoxModel> GetProducts()
        {
            List<ProductComboBoxModel> productList = new List<ProductComboBoxModel>();
            List<Product> books = db.Products.ToList(); // 异步执行查询

            foreach (Product book in books)
            {
                productList.Add(new ProductComboBoxModel(book.Code, book.Name));
            }
            // finish the method 

            return productList;
        }

        //TODO//
        public void AddItem(InsurancePolicy newPolicy)
        {
        

                //var item = new InsurancePolicy
                //{
                //    Name = "笔记本电脑",
                //    Price = 5999,
                //    Category = category
                //};
                //db.InsurancePolicies.Add(item);

                //db.SaveChanges();
            
            //finish the method 
        }
    }
}
