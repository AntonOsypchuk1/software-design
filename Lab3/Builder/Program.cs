using Builder.CharacterBuilder;

HeroBuilder heroBuilder = new HeroBuilder();
CharacterDirector heroDirector = new CharacterDirector(heroBuilder);
heroDirector.BuildCharacter();
Character hero = heroDirector.GetCharacter();

EnemyBuilder enemyBuilder = new EnemyBuilder();
CharacterDirector enemyDirector = new CharacterDirector(enemyBuilder);
enemyDirector.BuildCharacter();
Character enemy = enemyDirector.GetCharacter();