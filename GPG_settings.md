# GPG Key Settings / Troubleshooting

If you get an error like the below and the key was initially set up correctly the most likely reason is that the key expired.

    gpg failed to sign the data

Run the command below to check if any key has expired:

    gpg --list-keys

If the key is expired, follow the instructions below to generate and update your GPG key. When doing so, make sure the email address matches the one specified in your GitHub account and the key is set to expire no longer than in 3 months.

https://docs.github.com/en/authentication/managing-commit-signature-verification/generating-a-new-gpg-key


### The next thing is telling Git to use your new generated key

Use the command below to list your new key:

    gpg --list-secret-keys --keyid-format=long

Grab the long key format of the above signing key as explained in the link below.

Then tell git to use your new key:

    git config --global user.signingkey 3AA5C34371567BD2


More details on this link: 

https://docs.github.com/en/authentication/managing-commit-signature-verification/telling-git-about-your-signing-key
