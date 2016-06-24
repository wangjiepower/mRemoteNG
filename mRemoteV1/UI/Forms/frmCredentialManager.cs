﻿using System;
using System.Windows.Forms;
using mRemoteNG.App;

namespace mRemoteNG.UI.Forms
{
    public partial class FrmCredentialManager : Form
    {
        public FrmCredentialManager()
        {
            InitializeComponent();
            Load += OnLoad;
        }

        private void OnLoad(object sender, EventArgs eventArgs)
        {
            PopulateCredentialList();
        }

        private void PopulateCredentialList()
        {
            Runtime.CredentialList.CollectionChanged += CredentialList_CollectionChanged;
            olvCredentialList.SetObjects(Runtime.CredentialList);
        }

        private void CredentialList_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            olvCredentialList.SetObjects(Runtime.CredentialList);
        }

        private void btnAddCredential_Click(object sender, EventArgs e)
        {
            ShowCredentialEditor();
        }

        private void btnEditCredential_Click(object sender, EventArgs e)
        {
            ShowCredentialEditor();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowCredentialEditor()
        {
            var credentialEditor = new FrmCredentialEditor();
            credentialEditor.Show();
        }
    }
}