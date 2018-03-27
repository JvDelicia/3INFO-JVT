package android.aplicativo01;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.EditText;
import android.widget.TextView;

public class PasswordActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_password);
    }

    private void acessar() {
        EditText edT_senha = findViewById(R.id.edT_senha);
        TextView txV_resposta = findViewById(R.id.txV_resposta);
        TextView txV_tentativas = findViewById(R.id.txV_tentativas);

        Byte tent = 0;

        while(tent <= 3) {
            if (edT_senha.getText().toString() == "java")
                txV_resposta.setText("Acesso Concebido");
            else {
                txV_resposta.setText("Acesso Negado!");
                String visor = tent.toString() + "de 3 tentativas";
                txV_tentativas.setText(visor);
            }
        }
        if(tent == 3)
            txV_tentativas.setText("Bloqueado");
    }
}