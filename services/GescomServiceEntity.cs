using GestionCommercial.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommercial.services
{
    class GescomServiceEntity
    {
        ModelGestionCommercial dao = new ModelGestionCommercial();
        public GescomServiceEntity()
        {

        }
        public Utilisateur SeConnecter (string login, string pwd )
        {
            return dao.Utilisateur.ToList().Where(
                u => u.Login.Trim().CompareTo(login) == 0 &&
                u.Pwd.Trim().CompareTo(pwd) == 0
                ).FirstOrDefault();
        }
        public void ListerUser(DataGridView dtgvUser)
        {
            dtgvUser.DataSource = dao.Utilisateur.ToList();
        }
        public bool CreerUser(Utilisateur user)
        {
            dao.Utilisateur.Add(user);
            return dao.SaveChanges() != 0;
        }

        public void ListerArticle(DataGridView dtgvArticle)
        {
            dtgvArticle.DataSource = dao.Article.ToList();
        }
        public bool CreerArticle(Article article)
        {
            dao.Article.Add(article);
            return dao.SaveChanges() != 0;
        }

        public bool CreerClient(Client clt)
        {
            dao.Client.Add(clt);
            return dao.SaveChanges() != 0;
        }


    }
}
